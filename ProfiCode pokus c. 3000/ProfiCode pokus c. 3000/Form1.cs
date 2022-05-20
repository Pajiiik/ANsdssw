using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading;

namespace ProfiCode_pokus_c._3000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //static bool PingHost(string nameOrAddress)
        //{
        //    bool pingable = false;
        //    Ping pinger = null;

        //    try
        //    {
        //        pinger = new Ping();
        //        PingReply reply = pinger.Send(nameOrAddress);
        //        pingable = reply.Status == IPStatus.Success;
        //    }
        //    catch (PingException)
        //    {
        //    }
        //    return pingable;
        //}
        //static string NameHost(string Address)
        //{
        //    try
        //    {
        //        string name = Dns.GetHostEntry(Address).HostName.ToString();
        //        return name;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        //List<int> first = new List<int>();
        //List<int> second = new List<int>();
        //List<int> third = new List<int>();
        //List<int> fourth = new List<int>();
        //List<int> five = new List<int>();
        //List<int> six = new List<int>();
        //List<int> seven = new List<int>();
        //List<int> eight = new List<int>();
        //List<int> nine = new List<int>();
        //List<int> ten = new List<int>();  


        //List<IP_Info> info = new List<IP_Info>();
        //private void OK_Button_Click(object sender, EventArgs e)
        //{

        //    string ip1 = textBox1.Text + "." + textBox2.Text + "." + textBox3.Text + ".";
        //    string ip2 = textBox5.Text + "." + textBox6.Text + "." + textBox7.Text + ".";

        //    int ip_start = int.Parse(textBox4.Text);

        //    int ip_end = int.Parse(textBox8.Text);

        //    int[] pole = new int[ip_end - ip_start];

        //    int counter = 1;

        //    for (int ip_list = ip_start; ip_list <= ip_end; ip_list++)
        //    {
        //        switch (counter)
        //        {
        //            case 1:
        //                first.Add(ip_list);
        //                break;
        //            case 2:
        //                second.Add(ip_list);
        //                break;
        //            case 3:
        //                third.Add(ip_list);
        //                break;
        //            case 4:
        //                fourth.Add(ip_list);
        //                break;
        //            case 5:
        //                five.Add(ip_list);
        //                break;
        //            case 6:
        //                six.Add(ip_list);
        //                break;
        //            case 7:
        //                seven.Add(ip_list);
        //                break;
        //            case 8:
        //                eight.Add(ip_list);
        //                break;
        //            case 9:
        //                nine.Add(ip_list);
        //                break;
        //            case 10:
        //                ten.Add(ip_list);
        //                counter = 0;
        //                break;
        //        }

        //        counter++;
        //    }
        //    starten_sie(ip1,ip2);
        //    dataGridView1.DataSource = info;
        //    dataGridView1.Visible = true;
        //}
        //async void cast_jedna(string ip1, string ip2)
        //{
        //    Parallel.For(0, first.Count, async i =>
        //    {
        //        //first[i];
        //        info.Add(new IP_Info
        //        {
        //            ID = first[i],
        //            IP = ip1 + first[i].ToString(),
        //            status = PingHost(ip1 + first[i].ToString()),
        //            Name = NameHost(ip2 + first[i].ToString())
        //        });
        //    });
        //}
        //async void cast_dva(string ip1, string ip2)
        //{
        //    Parallel.For(0, second.Count, i =>
        //    {
        //        info.Add(new IP_Info
        //        {
        //            ID = second[i],
        //            IP = ip1 + second[i].ToString(),
        //            status = PingHost(ip1 + second[i].ToString()),
        //            Name = NameHost(ip2 + second[i].ToString())
        //        });
        //    });

        //}
        //async void cast_tri(string ip1, string ip2)
        //{
        //    Parallel.For(0, third.Count, i =>
        //    {
        //        info.Add(new IP_Info
        //        {
        //            ID = third[i],
        //            IP = ip1 + third[i].ToString(),
        //            status = PingHost(ip1 + third[i].ToString()),
        //            Name = NameHost(ip2 + third[i].ToString())
        //        });
        //    });

        //}
        //async void cast_ctyri(string ip1, string ip2)
        //{
        //    Parallel.For(0, fourth.Count, i =>
        //    {
        //        info.Add(new IP_Info
        //        {
        //            ID = fourth[i],
        //            IP = ip1 + i.ToString(),
        //            status = PingHost(ip1 + fourth[i].ToString()),
        //            Name = NameHost(ip2 + fourth[i].ToString())
        //        });
        //    });

        //}
        //async void cast_pet(string ip1, string ip2)
        //{
        //    Parallel.For(0, five.Count, i =>
        //    {
        //        info.Add(new IP_Info
        //        {
        //            ID = five[i],
        //            IP = ip1 + five[i].ToString(),
        //            status = PingHost(ip1 + five[i].ToString()),
        //            Name = NameHost(ip2 + five[i].ToString())
        //        });
        //    });

        //}
        //async void cast_sest(string ip1, string ip2)
        //{
        //    Parallel.For(0, six.Count, i =>
        //    {
        //        info.Add(new IP_Info
        //        {
        //            ID = six[i],
        //            IP = ip1 + six[i].ToString(),
        //            status = PingHost(ip1 + six[i].ToString()),
        //            Name = NameHost(ip2 + six[i].ToString())
        //        });
        //    });

        //}
        //async void cast_sedm(string ip1, string ip2)
        //{
        //    Parallel.For(0, seven.Count, i =>
        //    {
        //        info.Add(new IP_Info
        //        {
        //            ID = seven[i],
        //            IP = ip1 + seven[i].ToString(),
        //            status = PingHost(ip1 + seven[i].ToString()),
        //            Name = NameHost(ip2 + seven[i].ToString())
        //        });
        //    });

        //}
        //async void cast_osm(string ip1, string ip2)
        //{
        //    Parallel.For(0, eight.Count, i =>
        //    {
        //        info.Add(new IP_Info
        //        {
        //            ID = eight[i],
        //            IP = ip1 + eight[i].ToString(),
        //            status = PingHost(ip1 + eight[i].ToString()),
        //            Name = NameHost(ip2 + eight[i].ToString())
        //        });
        //    });

        //}
        //async void cast_devet(string ip1, string ip2)
        //{
        //    Parallel.For(0, nine.Count, i =>
        //    {
        //        info.Add(new IP_Info
        //        {
        //            ID = nine[i],
        //            IP = ip1 + nine[i].ToString(),
        //            status = PingHost(ip1 + nine[i].ToString()),
        //            Name = NameHost(ip2 + nine[i].ToString())
        //        });
        //    });

        //}
        //async void cast_deset(string ip1, string ip2)
        //{
        //    Parallel.For(0, ten.Count, i =>
        //    {
        //        info.Add(new IP_Info
        //        {
        //            ID = ten[i],
        //            IP = ip1 + ten[i].ToString(),
        //            status = PingHost(ip1 + ten[i].ToString()),
        //            Name = NameHost(ip2 + ten[i].ToString())
        //        });
        //    });       





        //}

        ////info.Add(new IP_Info
        ////        {
        ////            ID = i,
        ////            IP = "192.168.2." + i.ToString(),
        ////            status = PingHost(ip1 + i.ToString()),
        ////             Name = NameHost(ip2 + i.ToString())
        ////        });


        //async void starten_sie(string ip1, string ip2)
        //{
        //    Thread vlakno0 = new Thread(new ThreadStart(() =>
        //    {
        //        cast_jedna(ip1,ip2);
        //    }));

        //    Thread vlakno1 = new Thread(new ThreadStart(() =>
        //    {
        //        cast_dva(ip1, ip2);
        //    }));

        //    Thread vlakno2 = new Thread(new ThreadStart(() =>
        //    {
        //        cast_tri(ip1, ip2);
        //    }));

        //    Thread vlakno3 = new Thread(new ThreadStart(() =>
        //    {
        //        cast_ctyri(ip1, ip2);
        //    }));
        //    Thread vlakno4 = new Thread(new ThreadStart(() =>
        //    {
        //        cast_pet(ip1, ip2);
        //    }));
        //    Thread vlakno5 = new Thread(new ThreadStart(() =>
        //    {
        //        cast_sest(ip1, ip2);
        //    }));
        //    Thread vlakno6 = new Thread(new ThreadStart(() =>
        //    {
        //        cast_sedm(ip1, ip2);
        //    }));
        //    Thread vlakno7 = new Thread(new ThreadStart(() =>
        //    {
        //        cast_osm(ip1, ip2);
        //    }));
        //    Thread vlakno8 = new Thread(new ThreadStart(() =>
        //    {
        //        cast_devet(ip1, ip2);
        //    }));
        //    Thread vlakno9 = new Thread(new ThreadStart(() =>
        //    {
        //        cast_deset(ip1, ip2);
        //    }));


        //    vlakno0.Start();
        //    vlakno1.Start();
        //    vlakno2.Start();
        //    vlakno3.Start();
        //    vlakno4.Start();
        //    vlakno5.Start();
        //    vlakno6.Start();
        //    vlakno7.Start();
        //    vlakno8.Start();
        //    vlakno9.Start();



        //}


        static string NameHost(string Address)
        {
            try
            {
                string name = Dns.GetHostEntry(Address).HostName.ToString();
                return name;
            }
            catch
            {
                return null;
            }
        }
        static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
            }
            return pingable;
        }


        private void OK_Button_Click(object sender, EventArgs e)
        {       
            List<IP_Info> info = new List<IP_Info>();
            int ip_start, ip_end;
            ip_start = int.Parse(textBox4.Text);
            ip_end = int.Parse(textBox8.Text);
            string ip1 = textBox1.Text + "." + textBox2.Text + "." + textBox3.Text + ".";
            string ip2 = textBox5.Text + "." + textBox6.Text + "." + textBox7.Text + ".";
            Parallel.For(ip_start, (ip_end+1), i =>
            {
                info.Add(new IP_Info
                {
                    ID = i,
                    IP = ip1 + i.ToString(),
                    status = PingHost(ip1 + i.ToString()),
                    Name = NameHost(ip2 + i.ToString())
                });
            });
            dataGridView1.DataSource = info;
            dataGridView1.Visible = true;

            button1.Enabled = true;
            OK_Button.Enabled = false;
        }
        class IP_Info
        {
            public int ID { get; set; }
            public string IP { get; set; }
            public string Name { get; set; }
            public bool status { get; set; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IP_Info IPS = new IP_Info();
            
            dataGridView1.DataSource = null;
            button1.Enabled = false;
            OK_Button.Enabled = true;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = textBox3.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = textBox1.Text;
        }
    }

}
