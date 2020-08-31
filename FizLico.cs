using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Kiseleva
{
    public partial class FizLico : Form
    {
        decimal Kurs(int d)
        {
            //Инициализируем объекта типа XmlTextReader и
            //загружаем XML документ с сайта центрального банка
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            //В эти переменные будем сохранять куски XML
            //с определенными валютами (Euro, USD)
            string USDXml = "";
            string EuroXML = "";
            //Перебираем все узлы в загруженном документе
            while (reader.Read())
            {
                //Проверяем тип текущего узла
                switch (reader.NodeType)
                {
                    //Если этого элемент Valute, то начинаем анализировать атрибуты
                    case XmlNodeType.Element:
                        if (reader.Name == "Valute")
                        {
                            if (reader.HasAttributes)
                            {
                                //Метод передвигает указатель к следующему атрибуту
                                while (reader.MoveToNextAttribute())
                                {
                                    if (reader.Name == "ID")
                                    {
                                        //Если значение атрибута равно R01235, то перед нами информация о курсе доллара
                                        if (reader.Value == "R01235")
                                        {
                                            //Возвращаемся к элементу, содержащий текущий узел атрибута
                                            reader.MoveToElement();
                                            //Считываем содержимое дочерних узлом
                                            USDXml = reader.ReadOuterXml();
                                        }
                                    }
                                    //Аналогичную процедуру делаем для ЕВРО
                                    if (reader.Name == "ID")
                                    {
                                        if (reader.Value == "R01239")
                                        {
                                            reader.MoveToElement();
                                            EuroXML = reader.ReadOuterXml();
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }
            }

            //Из выдернутых кусков XML кода создаем новые XML документы
            XmlDocument usdXmlDocument = new XmlDocument();
            usdXmlDocument.LoadXml(USDXml);
            XmlDocument euroXmlDocument = new XmlDocument();
            euroXmlDocument.LoadXml(EuroXML);
            //Метод возвращает узел, соответствующий выражению XPath
            XmlNode xmlNode = usdXmlDocument.SelectSingleNode("Valute/Value");

            //Считываем значение и конвертируем в decimal. Курс валют получен
            decimal usdValue = Convert.ToDecimal(xmlNode.InnerText);
            xmlNode = euroXmlDocument.SelectSingleNode("Valute/Value");
            decimal euroValue = Convert.ToDecimal(xmlNode.InnerText);
            if (d == 2)
                return usdValue;
            else
                return euroValue;
        }
        int CountryProf1(String A)
        {
            int p = 0;
            if (Offshor != null)
            {
                for (int i = 0; i < Offshor.RowCount; i++)
                {
                    Offshor.Rows[0].Selected = false;
                    if (Offshor.Rows[i].Cells[0].Value != null)
                    {
                        if (Offshor.Rows[i].Cells[0].Value.ToString().Equals(A))
                        {
                            p++;
                            return p;
                        }

                    }

                }

            }
            return p;
        }
        int CountryProf2(String A)
        {
            int p = 0;
            if (TerrCity != null)
            {
                for (int i = 0; i < TerrCity.RowCount; i++)
                {
                    TerrCity.Rows[1].Selected = false;
                    if (TerrCity.Rows[i].Cells[1].Value != null)
                    {
                        if (TerrCity.Rows[i].Cells[1].Value.ToString().Equals(A))
                        {
                            p++;
                            return p;
                        }
                    }

                }

            }
            return p;
        }
        bool Prof()
        {
            if (dataGridView1 != null)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[1].Selected = false;
                    if (dataGridView1.Rows[i].Cells[1].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(Familya1)
                        || dataGridView1.Rows[i].Cells[4].Value.ToString().Equals(Familya1))
                        {
                            if (dataGridView1.Rows[i].Cells[2].Value.ToString().Equals(NameKlient1)
                            || dataGridView1.Rows[i].Cells[5].Value.ToString().Equals(NameKlient1))
                            {
                                if (dataGridView1.Rows[i].Cells[3].Value.ToString().Equals(Otchestvo1)
                                || dataGridView1.Rows[i].Cells[6].Value.ToString().Equals(Otchestvo1))
                                {
                                    if (dataGridView1.Rows[i].Cells[7].Value.ToString().Contains(DataBirthd1))
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public String Familya1, NameKlient1, Otchestvo1, SizePay1 , DataBirthd1, Valuta1, CountryPay1, CountryBank1;

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FizLico(String Familya, String NameKlient, String Otchestvo, String DataBirthd, String SizePay, String Valuta, String CountryPay, String CountryBank)
        {
            Familya1 = Familya;
            NameKlient1 = NameKlient;
            Otchestvo1 = Otchestvo+"*";
            SizePay1 = SizePay;
            Valuta1 = Valuta;
            CountryPay1 = CountryPay;
            CountryBank1 = CountryBank;
            DataBirthd1 = ""+DataBirthd[0] + DataBirthd[1] + "." + DataBirthd[3] + DataBirthd[4] + "." + DataBirthd[6] + DataBirthd[7] + DataBirthd[8] + DataBirthd[9];
            InitializeComponent();
        }

        private void FizLico_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных1DataSet2.Террористические_страны". При необходимости она может быть перемещена или удалена.
            this.террористические_страныTableAdapter.Fill(this.база_данных1DataSet2.Террористические_страны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных1DataSet1.Оффшоры". При необходимости она может быть перемещена или удалена.
            this.оффшорыTableAdapter.Fill(this.база_данных1DataSet1.Оффшоры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных1DataSet.__Террористы_". При необходимости она может быть перемещена или удалена.
            this._Террористы_TableAdapter.Fill(this.база_данных1DataSet.@__Террористы_);
            decimal p;
            double indexnad = 0;
            if (Valuta1 == "Доллар")
            {
                p = Kurs(2) * Convert.ToDecimal(SizePay1);
            }
            else if (Valuta1 == "Евро")
            {
                p = Kurs(3) * Convert.ToDecimal(SizePay1);
            }
            else
            {
                p = Convert.ToDecimal(SizePay1);
            }
            if (p > 600000)
            {
                indexnad = indexnad + 3.5;
                label14.Text = "Да";
                label21.Text = "3,5";
            }
            else 
            {
                label14.Text = "Нет";
                label21.Text = "0";
            }
            if (Prof())
            {
                indexnad = indexnad + 4;
                label9.Text = "Да";
                label16.Text = "4";
            }
            else
            {
                //"Совпадений в базе не обнаружено";
                label9.Text = "Нет";
                label16.Text = "0";
            }
            //оффшорная проверка
            if (CountryProf1(CountryPay1) == 1&& CountryProf1(CountryBank1) == 1)
            {
                label10.Text = "Да";
                label11.Text = "Да";
                label17.Text = "1,5";
                label18.Text = "1,5";
                indexnad = indexnad + 3;
                //Обе страны оффшоры
            }
            else if(CountryProf1(CountryPay1) == 1)
            {
                label10.Text = "Да";
                label11.Text = "Нет";
                label17.Text = "1,5";
                label18.Text = "0";
                indexnad = indexnad + 1.5;
                //Страна платежа оффшор
            }
            else if(CountryProf1(CountryBank1) == 1)
            {
                label10.Text = "Да";
                label11.Text = "Нет";
                label17.Text = "0";
                label18.Text = "1,5";
                indexnad = indexnad + 1.5;
                //Страна эмитента оффшор
            }
            else 
            {
                label10.Text = "Нет";
                label11.Text = "Нет";
                label17.Text = "0";
                label18.Text = "0";//Нет стран оффшоров
            }
            //террористичекая проверка
            if (CountryProf2(CountryPay1) == 1 && CountryProf2(CountryBank1) == 1)
            {
                indexnad = indexnad + 3;
                //Обе страны входят в черный или серый список ФАТФ
                label12.Text = "Да";
                label13.Text = "Да";
                label19.Text = "1,5";
                label20.Text = "1,5";
            }
            else if (CountryProf2(CountryPay1) == 1)
            {
                indexnad = indexnad + 1.5;
                //Страна платежа входит в черный или серый список ФАТФ
                label12.Text = "Да";
                label13.Text = "Нет";
                label19.Text = "1,5";
                label20.Text = "0";
            }
            else if (CountryProf2(CountryBank1) == 1)
            {
                indexnad = indexnad + 1.5;
                //Страна эмитента входит в черный или серый список ФАТФ
                label12.Text = "Нет";
                label13.Text = "Да";
                label19.Text = "0";
                label20.Text = "1,5";
            }
            else
            {
                //Нет стран оффшоров
                label12.Text = "Нет";
                label13.Text = "Нет";
                label19.Text = "0";
                label20.Text = "0";
            }
            //проверка на разность стран
            if(CountryPay1==CountryBank1)
            {
                label15.Text = "Нет";
                label22.Text = "0";
            }
            else 
            {
                indexnad = indexnad + 1.5;
                //Страна эмитент отличается от страны платежа
                label15.Text = "Да";
                label22.Text = "1,5";
            }
            if(indexnad<5)
            {
                Like.Visible = true;
                Dislike.Visible = false;
                LikeOrDislike.Visible = false;
                Itog2.Text = "безопасный.";
            }
            else if(indexnad>8)
            {
                Like.Visible = false;
                Dislike.Visible = true;
                LikeOrDislike.Visible = false;
                Itog2.Text = "подозрительный!";
            }
            else
            {
                Like.Visible = false;
                Dislike.Visible = false;
                LikeOrDislike.Visible = true;
                Itog2.Text = "немного подозрительный.";
            }
            Itog.Text = indexnad.ToString() + "  баллов.";
        }
    }
}
