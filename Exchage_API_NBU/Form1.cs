using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchage
{
    public partial class Form1 : Form
    {
        public static decimal USD;
        public static decimal Evro;
        public static decimal UAN;
        public static decimal RUB;
        public static string usd;
        public static string evro;
        public static string uan ;
        public static string rub;

       static Logger logger = new Logger();
       Mail mail= new Mail();
        public static DateTime data = DateTime.Now;
        public static DateTime time = DateTime.Now;

        public  static  List<Elements> list;
        public Form1()
        {
            InitializeComponent();
            Listen().GetAwaiter();
            usd_exchange.Text = usd;
            evro_exchange.Text = evro;
            rub_exchange.Text = rub;

            Buy.Items.AddRange(new object[] { "USD", "EUR", "UAN","RUB" });
            comboBox_IN.Items.AddRange(new object[] { "USD", "EUR", "UAN","RUB" });

              textBox1.Text= "Exchange" + Environment.NewLine;
         }

        private static async Task Listen()
        {
            WebRequest request = WebRequest.Create("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange");

            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(stream))
                    {
                        string data = reader.ReadToEnd();
                        if (data.Contains("Долар США") && data.Contains("Євро") && data.Contains("Російський рубль"))
                        {
                            usd = data.Substring(data.IndexOf("Долар США") + "Долар США".Length + 17, 9);
                            evro = data.Substring(data.IndexOf("Євро") + "Євро".Length + 17, 9);
                            rub= data.Substring(data.IndexOf("Російський рубль") + "Російський рубль".Length + 17, 7);


                            try
                            {
                                USD = decimal.Parse(usd, CultureInfo.InvariantCulture);
                                Evro = decimal.Parse(evro, CultureInfo.InvariantCulture);
                                RUB = decimal.Parse(rub, CultureInfo.InvariantCulture);

                                Elements _usd = new Elements("USD", USD);
                                Elements _evro = new Elements("EUR", Evro);
                                Elements _uan = new Elements("UAN", UAN);
                                Elements _rub = new Elements("RUB", RUB);

                                list = new List<Elements>
                                {
                                    new Elements("USD", USD){},
                                    new Elements("EUR", Evro){},
                                    new Elements("UAN", UAN){},
                                    new Elements("RUB",RUB){}
                                };
                           
                            }
                            catch (Exception ex)
                            {
                                logger.WriteLine(ex.Message);
                            }
                        }
                    }
                }
            }
        }
      
        public   string NameNote_buy;
        public  string NameNote_sell;
        private void Change_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            var Name_note_to_buy = Buy.SelectedItem;
            var Name_note_in = comboBox_IN.SelectedItem;

           var mailaddress = textBoxMailAddress.Text;

            decimal buy = 0;
            decimal sell = 0;
            decimal sum = 0;


                try
                {
               
                    decimal amount_to_by = decimal.Parse(amount_To_buy.Text, CultureInfo.InvariantCulture);
                   

                    foreach (var i in list)
                    {
                        if (Name_note_in == i.name)
                            {
                                sell = i.note;
                               NameNote_sell = i.name;
                             }
                        if (Name_note_to_buy == i.name)
                               {
                                   buy = i.note;
                                   NameNote_buy = i.name;
                                }
                        if (NameNote_sell == "UAN")
                             {
                                 sell = amount_to_by;
                                 sum = buy * sell;
                              }
                        if(NameNote_buy=="RUB"&& NameNote_sell=="UAN")
                            {
                               sum = buy * amount_to_by;
                            }
                        if (NameNote_sell == "USD" && NameNote_buy == "EUR" 
                             || NameNote_sell == "EUR" && NameNote_buy == "USD"
                             || NameNote_sell == "RUB" && NameNote_buy == "USD"
                             || NameNote_sell == "USD" && NameNote_buy == "RUB"
                             || NameNote_sell == "RUB" && NameNote_buy == "EUR"
                             || NameNote_sell == "EUR" && NameNote_buy == "RUB")
                             {
                                sum = (buy / sell) * amount_to_by;
                              }
                    }
               

                textBox1.Text += "**********Check***********\r\n"+"Date    "+ data.ToString("d")+ "\r\nTime   "+time.ToString("t") + "\r\n"
                                                + "Amount:  " + amount_to_by.ToString() + " " + Name_note_to_buy.ToString() + 
                                                " = " + decimal.ToSingle(sum).ToString() + " " + NameNote_sell.ToString()+"\r\n\r\n";

                logger.WriteLine ("\r\n**********Check***********\r\n"+"Date    "+ data.ToString("d") + "\r\nTime   "+time.ToString("t") + "\r\n"
                                               +"Amount:  "+  amount_to_by.ToString() + " " + Name_note_to_buy.ToString() + 
                                               " = " + decimal.ToSingle(sum).ToString() + " " + NameNote_sell.ToString()+"\r\n\r\n");

               logger.Write("\r\n**********Check***********\r\n" + "Date    " + data.ToString("d") + "\r\nTime   " + time.ToString("t") + "\r\n"
                                               + "Amount:  " + amount_to_by.ToString() + " " + Name_note_to_buy.ToString() +
                                               " = " + decimal.ToSingle(sum).ToString() + " " + NameNote_sell.ToString() + "\r\n\r\n");

                try
                {
                           Mail.sendMailAsync(mailaddress).GetAwaiter();
                           textBox1.AppendText("Check been sending!");

                }
                catch (Exception ex)
                {
                    textBox1.AppendText("Check not been send!");
                }

             }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
          
         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < list.Count; i++)
            //{
            //    textBox1.Text+=list[i].name.ToString() + "   " + list[i].note.ToString() + Environment.NewLine;
            //}
            //textBox1.AppendText(list[0].name.ToString() + " " + list[0].note.ToString() + "\r\n");
            //textBox1.AppendText( list[1].name.ToString() + " " + list[1].note.ToString() + "\r\n");
            //textBox1.AppendText( list[2].name.ToString() + " " + list[2].note.ToString() + "\r\n");
        }

     
    }
}
