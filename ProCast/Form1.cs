using BL;
using Models;
using System.Timers;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProCast

{
    public partial class Form1 : Form
    {

        private System.Windows.Forms.Timer minTimer = new System.Windows.Forms.Timer();
        PodManager podManager;
        KategoriManager kategoriManager;
        public Form1()
        {
            podManager = new PodManager();
            kategoriManager = new KategoriManager();
            InitializeComponent();
            fillPoddarUpdated();
            fillKategorier();
            minTimer.Interval = 5000;
            minTimer.Tick += minTimerTick;
            minTimer.Start();
        }

        private async void minTimerTick(object sender, EventArgs e)
        {
            List<PoddCast> allaPoddar = podManager.getPoddList();
            foreach (PoddCast enPodd in allaPoddar)
            {
                if (enPodd.NeedsUpdate)
                {
                    await podManager.updateEpisodes(enPodd.Url);
                }
            }

        }

        private async void btnLaggTillFlode_Click(object sender, EventArgs e)
        {
            bool kor = true;
            string url = txtUrl.Text;
            string intervallString = cmbIntervall.Text.ToString();
            if (ValidateRss.urlExist(url))
            {

                MessageBox.Show("Du prenumererar redan på denna podd!");
                kor = false;
            }

            if (Validering.TomtFalt(txtNamn))
            {
                MessageBox.Show("Vänligen skriv in ett namn");
                kor = false;
            }

            if (Validering.TomtFalt(cmbIntervall))
            {
                MessageBox.Show("Vänligen välj intervall");
                kor = false;
            }

            if (Validering.TomtFalt(cmbKategori))
            {
                MessageBox.Show("Vänligen fyll i en kategori");
                kor = false;
            }

            if (!ValidateRss.RssValidering(txtUrl.Text))
            {
                MessageBox.Show("RSS-flöde är ogiltigt.");
                kor = false;
            }

            if (kor)
            {
                int intervall = PoddCast.convertIntervallFromString(intervallString);
                string namn = txtNamn.Text;
                string kategori = cmbKategori.Text;
                await podManager.createNew(url, namn, kategori, intervall);
                PoddCast skapadPodd = podManager.getPoddByUrl(url);
                addPoddToView(skapadPodd);
                txtNamn.Clear();
                txtUrl.Clear();
            }

        }

        private void btnLaggTillKategori_Click(object sender, EventArgs e)
        {
            string kategoriNamn = txtKategoriInput.Text;
            if (!string.IsNullOrEmpty(kategoriNamn))
            {
                txtKategoriInput.Clear();
                kategoriManager.createNew(kategoriNamn);
                Kategori skapadKategori = kategoriManager.getKategoriByNamn(kategoriNamn);
                addKategoriToSee(skapadKategori);
            }
        }

        public void txtKategoriInput_TextChanged(object sender, EventArgs e)
        {

        }

        public void cmbFiltrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valdKategori = cmbFiltrera.SelectedItem as string;
            List<PoddCast> allaPoddar = podManager.getPoddList();
            var listaAvFiltrerade = allaPoddar.Where(enPoddCast => enPoddCast.Kategori.Equals(valdKategori)).ToList();
            listViewPodd.Items.Clear();
            foreach (PoddCast enPodd in listaAvFiltrerade)
            {
                addPoddToView(enPodd);
            }

        }



        private async void btnAndraKategori_Click(object sender, EventArgs e)
        {
            if (lstbxKategorier.SelectedIndex != -1)
            {
                int selectedIndex = lstbxKategorier.SelectedIndex;
                string gammalText = lstbxKategorier.Items[selectedIndex].ToString();
                string nyKategoriText = txtKategoriInput.Text;
                if (string.Equals(nyKategoriText, lstbxKategorier.Items[selectedIndex].ToString()))
                {

                }

                else if (!string.IsNullOrEmpty(nyKategoriText))
                {
                    lstbxKategorier.Items[selectedIndex] = nyKategoriText;
                    txtKategoriInput.Clear();
                    int indexOfKat = cmbKategori.FindStringExact(gammalText);
                    cmbKategori.Items[indexOfKat] = nyKategoriText;
                    int indexOfFilt = cmbFiltrera.FindStringExact(gammalText);
                    cmbFiltrera.Items[indexOfFilt] = nyKategoriText;
                    Kategori kategoriAttAndra = kategoriManager.getKategoriByNamn(gammalText);
                    kategoriManager.updateKategori(kategoriAttAndra, nyKategoriText);
                    await podManager.andraKategori(gammalText, nyKategoriText);
                    listViewPodd.Items.Clear();
                    fillPoddar();
                }

            }
        }

        private async void btnTaBortKategori_Click(object sender, EventArgs e)
        {

            int selectedIndex = lstbxKategorier.SelectedIndex;
            if (lstbxKategorier.SelectedIndex != -1)

                if (Validering.TaBortValidering(lstbxKategorier))
                {

                    string gammalText = lstbxKategorier.Items[selectedIndex].ToString();

                    {
                        lstbxKategorier.Items.RemoveAt(lstbxKategorier.SelectedIndex);
                        txtKategoriInput.Clear();
                        int indexOfKat = cmbKategori.FindStringExact(gammalText);
                        cmbKategori.Items.RemoveAt(indexOfKat);
                        int indexOfFilt = cmbFiltrera.FindStringExact(gammalText);
                        cmbFiltrera.Items.RemoveAt(indexOfFilt);
                        Kategori kategoriToDelete = kategoriManager.getKategoriByNamn(gammalText);
                        kategoriManager.delete(kategoriToDelete);
                        await podManager.andraKategori(gammalText, " ");
                        listViewPodd.Items.Clear();
                        fillPoddar();
                    }
                }
        }

        private void lstbxKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbxKategorier.SelectedIndex != -1) // Kontrollera om någon rad är markerad
            {
                if (lstbxKategorier.SelectedItem != null) // Kontrollera om SelectedItem är inte null
                {
                    txtKategoriInput.Text = lstbxKategorier.SelectedItem.ToString();
                }
            }
        }


        private async void btnAndraFlode_Click(object sender, EventArgs e)
        {

            if (listViewPodd.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listViewPodd.SelectedItems[0];
                int indexToChange = listViewPodd.Items.IndexOf(selectedRow);
                PoddCast gammalPodd = selectedRow.Tag as PoddCast;
                string url = txtUrl.Text;
                string namn = txtNamn.Text;
                string kategori = cmbKategori.Text;
                int intervall = PoddCast.convertIntervallFromString(cmbIntervall.Text);


                if (gammalPodd.Url.Equals(url))
                {

                    PoddCast nyPodd = await podManager.updatePoddNew(url, namn, kategori, intervall);
                    addPoddToView(nyPodd, indexToChange);
                }
                else
                {
                    MessageBox.Show("Du kan inte ändra länken på en podd");
                }

            }
        }

        private void changeListViewItem(ListViewItem item)
        {

        }


        private void listViewPodd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPodd.SelectedItems.Count > 0)
            {
                listViewAvsnitt.Items.Clear();
                ListViewItem chosenItem = listViewPodd.SelectedItems[0];
                txtNamn.Text = chosenItem.SubItems[1].Text;
                string kategori = chosenItem.SubItems[3].Text;
                int kategoriIndex = cmbKategori.FindStringExact(kategori);
                cmbKategori.SelectedIndex = kategoriIndex;
                string intervall = chosenItem.SubItems[4].Text;
                int intervallIndex = cmbIntervall.FindStringExact(intervall);
                cmbIntervall.SelectedIndex = intervallIndex;
                PoddCast enPodd = chosenItem.Tag as PoddCast;
                txtUrl.Text = enPodd.Url;
                List<Avsnitt> poddensAvsnitt = enPodd.Avsnitten;
                foreach (Avsnitt ettAvsnitt in poddensAvsnitt)
                {
                    string title = ettAvsnitt.Title;
                    ListViewItem avsnittItem = new ListViewItem(title);
                    avsnittItem.Tag = ettAvsnitt;
                    listViewAvsnitt.Items.Add(avsnittItem);

                }


            }
        }

        private void listViewAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAvsnitt.SelectedItems.Count > 0)
            {
                ListViewItem chosenItem = listViewAvsnitt.SelectedItems[0];
                Avsnitt avsnittObject = chosenItem.Tag as Avsnitt;
                textBoxDescription.Text = avsnittObject.Description;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTaBortFlode_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPodd.Items.Count > 0)
                {
                    ListViewItem chosenItem = listViewPodd.SelectedItems[0];
                    PoddCast poddToRemove = chosenItem.Tag as PoddCast;
                    if (Validering.TaBortValidering(listViewPodd))
                    {
                        listViewPodd.Items.Remove(chosenItem);
                        podManager.deletePodd(poddToRemove);
                    }
                }
            }
            catch (Exception ettException)
            {
                MessageBox.Show("Du har inte valt något flöde att ta bort!");
            }
        }
        //överlagrad metod
        private void addPoddToView(PoddCast skapadPodd)
        {
            ListViewItem enPodd = new ListViewItem(skapadPodd.Title);
            enPodd.SubItems.Add(skapadPodd.Namn);
            enPodd.SubItems.Add(" " + skapadPodd.EpisodesCount);
            enPodd.SubItems.Add(skapadPodd.Kategori);
            enPodd.SubItems.Add(skapadPodd.IntervallSträng);
            enPodd.Tag = skapadPodd;
            listViewPodd.Items.Add(enPodd);
        }

        //överlagrad metod
        private void addPoddToView(PoddCast podd, int index)
        {
            ListViewItem nyttItem = new ListViewItem(podd.Title);
            nyttItem.SubItems.Add(podd.Namn);
            nyttItem.SubItems.Add(" " + podd.EpisodesCount);
            nyttItem.SubItems.Add(podd.Kategori);
            nyttItem.SubItems.Add(podd.IntervallSträng);
            nyttItem.Tag = podd;
            listViewPodd.Items[index] = nyttItem;
        }

        private void addKategoriToSee(Kategori enKategori)
        {
            string kategoriText = enKategori.Namn;
            if (!string.IsNullOrEmpty(kategoriText))
            {
                lstbxKategorier.Items.Add(kategoriText);
                txtKategoriInput.Clear();
                cmbKategori.Items.Add(kategoriText);
                cmbFiltrera.Items.Add(kategoriText);
            }
        }

        private async void fillPoddarUpdated()
        {
            await podManager.updateEpisodesAll();
            List<PoddCast> poddarFromFile = podManager.getPoddList();
            foreach (PoddCast enPodd in poddarFromFile)
            {
                addPoddToView(enPodd);
            }

        }

        private void fillPoddar()
        {
            List<PoddCast> poddarFromFile = podManager.getPoddList();
            foreach (PoddCast enPodd in poddarFromFile)
            {
                addPoddToView(enPodd);
            }
        }



        private void fillKategorier()
        {
            List<Kategori> kategorierFromFile = kategoriManager.getAll();
            foreach (Kategori enKategori in kategorierFromFile)
            {
                addKategoriToSee(enKategori);
            }
        }

        private void btnAterstall_Click(object sender, EventArgs e)
        {
            listViewPodd.Items.Clear();
            fillPoddar();
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            txtNamn.Clear();
            txtUrl.Clear();
        }
    }
}