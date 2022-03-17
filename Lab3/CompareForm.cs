using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{


    public partial class CompareForm : Form
    {
        public CompareForm()
        {
            InitializeComponent();
        }

        const int N = 100000;
        OnlineStore[] onlineStoresArray = new OnlineStore[N];
        Dictionary<string, OnlineStore> onlineStoresDictionary = new Dictionary<string, OnlineStore>();

        long FillArray()
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < N; i++)
            {
                onlineStoresArray[i] = new OnlineStore(i.ToString(), i.ToString());
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }


        long FillDicitonary()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            onlineStoresDictionary.Clear();
            for (int i = 0; i < N; i++)
            {
                onlineStoresDictionary.Add(i.ToString(), new OnlineStore(i.ToString(), i.ToString()));
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        long ChooseArraySeq()
        {
            OnlineStore onlineStore;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < N; i++)
            {
                onlineStore = onlineStoresArray[i];
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        long ChooseArrayRandom()
        {
            Random radnom = new Random();
            OnlineStore onlineStore;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < N; i++)
            {
                onlineStore = onlineStoresArray[radnom.Next(onlineStoresArray.Length)];
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        long ChooseDictionarySeq()
        {
            OnlineStore onlineStore;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < N; i++)
            {
                onlineStore = onlineStoresDictionary[i.ToString()];
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        long ChooseDictionaryRandom()
        {
            Random radnom = new Random();
            OnlineStore onlineStore;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < N; i++)
            {
                onlineStore = onlineStoresDictionary[radnom.Next(0, onlineStoresArray.Length).ToString()];
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private void CompareForm_Load(object sender, EventArgs e)
        {


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItemDictionary = new ListViewItem();
            listViewItemDictionary.Text = "Dictionary";
            listViewItemDictionary.SubItems.Add($"{FillDicitonary()} ms");
            listViewItemDictionary.SubItems.Add($"{ChooseDictionarySeq()} ms");
            listViewItemDictionary.SubItems.Add($"{ChooseDictionaryRandom()} ms");



            ListViewItem listViewItemArray = new ListViewItem();
            listViewItemArray.Text = "Array";
            listViewItemArray.SubItems.Add($"{FillArray()} ms");
            listViewItemArray.SubItems.Add($"{ChooseArraySeq()} ms");
            listViewItemArray.SubItems.Add($"{ChooseArrayRandom()} ms");



            listView1.Items.Add(listViewItemDictionary);
            listView1.Items.Add(listViewItemArray);

        }
    }
}
