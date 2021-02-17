using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ignat_Cristian_Aplicatie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int mCiorbaRadauteana = 0;
        private int mCiorbaAlagrec = 0;
        private int mCiorbadelegume = 0;
        private int mCiorbadeburta = 0;
        private int mFelPrincipalSalataLight = 0;
        private int mFelPrincipalCartofiPiureecufriptura = 0;
        private int mFelPrincipalPastrav = 0;
        private int mFelPrincipalCarbonara = 0;
        private int mFelPrincipalSalataOrientala = 0;
        private int mDesertLavacake = 0;
        private int mDesertClatite = 0;
        private int mDesertPapanasi = 0;
        private int mDesertMousse = 0;
        private double Total = 0;
        private FoodType selectedFood;

        KeyValuePair<FoodType, double>[] priceList =
        {
            new KeyValuePair<FoodType, double>(FoodType.Radauteana, 16),
            new KeyValuePair<FoodType, double>(FoodType.Alagrec, 15),
            new KeyValuePair<FoodType, double>(FoodType.Ciorbalegume, 13),
            new KeyValuePair<FoodType, double>(FoodType.Ciorbadeburta, 17),
            new KeyValuePair<FoodType, double>(FoodType.SalataLight, 14),
            new KeyValuePair<FoodType, double>(FoodType.Piuree, 15),
            new KeyValuePair<FoodType, double>(FoodType.Pastrav, 19),
            new KeyValuePair<FoodType, double>(FoodType.Carbonara, 20),
            new KeyValuePair<FoodType, double>(FoodType.SalataOrientala, 17),
            new KeyValuePair<FoodType, double>(FoodType.Lavacake, 18),
            new KeyValuePair<FoodType, double>(FoodType.Clatite, 15),
            new KeyValuePair<FoodType, double>(FoodType.Papanasi, 14),
            new KeyValuePair<FoodType, double>(FoodType.Mousse, 17)

        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private int ValidateQuantity(FoodType selectedFood)
        {
            int q = int.Parse(txtQuantity.Text);
            int r = 1;

            switch(selectedFood)
            {
                case FoodType.Radauteana:
                    if (q > mCiorbaRadauteana)
                        r = 0;
                    break;
                case FoodType.Alagrec:
                    if (q > mCiorbaAlagrec)
                        r = 0;
                    break;
                case FoodType.Ciorbalegume:
                    if (q > mCiorbadelegume)
                        r = 0;
                    break;
                case FoodType.Ciorbadeburta:
                    if (q > mCiorbadeburta)
                        r = 0;
                    break;
                case FoodType.SalataLight:
                    if (q > mFelPrincipalSalataLight)
                        r = 0;
                    break;
                case FoodType.Piuree:
                    if (q > mFelPrincipalCartofiPiureecufriptura)
                        r = 0;
                    break;
                case FoodType.Pastrav:
                    if (q > mFelPrincipalPastrav)
                        r = 0;
                    break;
                case FoodType.Carbonara:
                    if (q > mFelPrincipalCarbonara)
                        r = 0;
                    break;
                case FoodType.SalataOrientala:
                    if (q > mFelPrincipalSalataOrientala)
                        r = 0;
                    break;
                case FoodType.Lavacake:
                    if (q > mDesertLavacake)
                        r = 0;
                    break;
                case FoodType.Clatite:
                    if (q > mDesertClatite)
                        r = 0;
                    break;
                case FoodType.Papanasi:
                    if (q > mDesertPapanasi)
                        r = 0;
                    break;
                case FoodType.Mousse:
                    if (q > mDesertMousse)
                        r = 0;
                    break;
            }
            return r;
        }

        private void RadauteanaMenuItem_Click_(object sender, RoutedEventArgs e)
        {
            mCiorbaRadauteana++;
            txtCiorbăRadauteana.Text = mCiorbaRadauteana.ToString();
        }

        private void AlagrecMenuItem_Click_(object sender, RoutedEventArgs e)
        {
            mCiorbaAlagrec++;
            txtCiorbaalagrec.Text = mCiorbaAlagrec.ToString();
        }

        private void CiorbadelegumeMenuItem_Click_(object sender, RoutedEventArgs e)
        {
            mCiorbadelegume++;
            txtCiorbadelegume.Text = mCiorbadelegume.ToString();
        }

        private void CiorbadeburtaMenuItem_Click_(object sender, RoutedEventArgs e)
        {
            mCiorbadeburta++;
            txtCiorbadeburta.Text = mCiorbadeburta.ToString();
        }

        private void SalataLightMenuItem_Click_(object sender, RoutedEventArgs e)
        {
            mFelPrincipalSalataLight++;
            txtSalataLight.Text = mFelPrincipalSalataLight.ToString();
        }

        private void CartofiPiureecufripturaMenuItem_Click_(object sender, RoutedEventArgs e)
        {
            mFelPrincipalCartofiPiureecufriptura++;
            txtCartofiPiureecufriptura.Text = mFelPrincipalCartofiPiureecufriptura.ToString();
        }

        private void PastravlacuptorMenuItem_Click_(object sender, RoutedEventArgs e)
        {
            mFelPrincipalPastrav++;
            txtPastravlacuptor.Text = mFelPrincipalPastrav.ToString();
        }

        private void PasteCarbonaraMenuItem_Click_(object sender, RoutedEventArgs e)
        {
            mFelPrincipalCarbonara++;
            txtPasteCarbonara.Text = mFelPrincipalCarbonara.ToString();
        }

        private void SalataOrientalaMenuItem_Click_(object sender, RoutedEventArgs e)
        {
            mFelPrincipalSalataOrientala++;
            txtFelPrincipalSalataOrientaladevara.Text = mFelPrincipalSalataOrientala.ToString();
        }

        private void LavacakeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            mDesertLavacake++;
            txtLavaCakecuinghetata.Text = mDesertLavacake.ToString();
        }

        private void ClatiteMenuItem_Click_(object sender, RoutedEventArgs e)
        {
            mDesertClatite++;
            txtClatitecubananesiciocolata.Text = mDesertClatite.ToString();
        }

        private void PapanasiMenuItem_Click_(object sender, RoutedEventArgs e)
        {
            mDesertPapanasi++;
            txtPapanasi.Text = mDesertPapanasi.ToString();
        }

        private void MousseMenuItem_Click_(object sender, RoutedEventArgs e)
        {
            mDesertMousse++;
            txtDarkChocolateMousse.Text = mDesertMousse.ToString();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MealItemShow_Click(object sender, RoutedEventArgs e)
        {
            string mesaj;
            MenuItem SelectedItem = (MenuItem)e.OriginalSource;
            mesaj = SelectedItem.Header.ToString() + " se prepara!";
            this.Title = mesaj;
        }

        private void frmMain_Loaded(object sender, RoutedEventArgs e)
        {
            cmbType.ItemsSource = priceList;
            cmbType.DisplayMemberPath = "Key";
            cmbType.SelectedValuePath = "Value";
        }

        private void cmbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtPrice.Text = cmbType.SelectedValue.ToString();
            KeyValuePair<FoodType, double> selectedEntry = (KeyValuePair<FoodType, double>)cmbType.SelectedItem;
            selectedFood = selectedEntry.Key;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateQuantity(selectedFood) > 0)
            {
                lstSale.Items.Add(txtQuantity.Text + " " + selectedFood.ToString() + ":" + txtPrice.Text + " " + double.Parse(txtQuantity.Text) * double.Parse(txtPrice.Text));
                Total = Total + double.Parse(txtQuantity.Text) * double.Parse(txtPrice.Text);
                txtTotal.Text = Total.ToString();
            }
            else
            {
                MessageBox.Show("Preparatul nu este disponibil in stoc!");
            }
        }

        private void btnRemoveItem_Click(object sender, RoutedEventArgs e)
        {
            lstSale.Items.Remove(lstSale.SelectedItem);
        }

        private void btnCheckOut_Click(object sender, RoutedEventArgs e)
        {
            txtTotal.Text = "0";
            foreach (string s in lstSale.Items)
            {
                switch (s.Substring(s.IndexOf(" ") + 1, s.IndexOf(":") - s.IndexOf(" ") - 1))
                {
                    case "Radauteana":
                        mCiorbaRadauteana = mCiorbaRadauteana - Int32.Parse(s.Substring(0, s.IndexOf(" ")));
                        txtCiorbăRadauteana.Text = mCiorbaRadauteana.ToString();
                        break;
                    case "A la grec":
                        mCiorbaAlagrec = mCiorbaAlagrec - Int32.Parse(s.Substring(0, s.IndexOf(" ")));
                        txtCiorbaalagrec.Text = mCiorbaAlagrec.ToString();
                        break;
                    case "Ciorba de legume":
                        mCiorbadelegume = mCiorbadelegume - Int32.Parse(s.Substring(0, s.IndexOf(" ")));
                        txtCiorbadelegume.Text = mCiorbadelegume.ToString();
                        break;
                    case "Ciorba de burta":
                        mCiorbadeburta = mCiorbadeburta - Int32.Parse(s.Substring(0, s.IndexOf(" ")));
                        txtCiorbadeburta.Text = mCiorbadeburta.ToString();
                        break;
                    case "Salata Light":
                        mFelPrincipalSalataLight = mFelPrincipalSalataLight - Int32.Parse(s.Substring(0, s.IndexOf(" ")));
                        txtSalataLight.Text = mFelPrincipalSalataLight.ToString();
                        break;
                    case "Cartofi Piuree":
                        mFelPrincipalCartofiPiureecufriptura = mFelPrincipalCartofiPiureecufriptura - Int32.Parse(s.Substring(0, s.IndexOf("")));
                        txtCartofiPiureecufriptura.Text = mFelPrincipalCartofiPiureecufriptura.ToString();
                        break;
                    case "Pastrav la cuptor":
                        mFelPrincipalPastrav = mFelPrincipalPastrav - Int32.Parse(s.Substring(0, s.IndexOf(" ")));
                        txtPastravlacuptor.Text = mFelPrincipalPastrav.ToString();
                        break;
                    case "Paste Carbonara":
                        mFelPrincipalCarbonara = mFelPrincipalCarbonara - Int32.Parse(s.Substring(0, s.IndexOf(" ")));
                        txtPasteCarbonara.Text = mFelPrincipalCarbonara.ToString();
                        break;
                    case "Salata Orientala":
                        mFelPrincipalSalataOrientala = mFelPrincipalSalataOrientala - Int32.Parse(s.Substring(0, s.IndexOf(" ")));
                        txtFelPrincipalSalataOrientaladevara.Text = mFelPrincipalSalataOrientala.ToString();
                        break;
                    case "Lavacake":
                        mDesertLavacake = mDesertLavacake - Int32.Parse(s.Substring(0, s.IndexOf(" ")));
                        txtLavaCakecuinghetata.Text = mDesertLavacake.ToString();
                        break;
                    case "Clatite":
                        mDesertClatite = mDesertClatite - Int32.Parse(s.Substring(0, s.IndexOf(" ")));
                        txtClatitecubananesiciocolata.Text = mDesertClatite.ToString();
                        break;
                    case "Papanasi":
                        mDesertPapanasi = mDesertPapanasi - Int32.Parse(s.Substring(0, s.IndexOf(" ")));
                        txtPapanasi.Text = mDesertPapanasi.ToString();
                        break;
                    case "Mousse":
                        mDesertMousse = mDesertMousse - Int32.Parse(s.Substring(0, s.IndexOf(" ")));
                        txtDarkChocolateMousse.Text = mDesertMousse.ToString();
                        break;
                }
            }
            lstSale.Items.Clear();
        }

        private void txtQuantity_KeyPress(object sender, KeyEventArgs e)
        {
            if(!(e.Key>=Key.D0 && e.Key<=Key.D9))
            {
                MessageBox.Show(" Numai cifre se pot introduce!", "Input Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
