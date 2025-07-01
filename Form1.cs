using SergeevaAA_01_00;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SergeevaAA_01_00
{
    public partial class SergeevaAA_01_00 : Form
    {
        public SergeevaAA_01_00()
        {
            InitializeComponent();
            RoadWorkList.SelectionMode = SelectionMode.MultiExtended;
            SeasonWorkList.SelectionMode = SelectionMode.MultiExtended;
        }

        private void UpdateLists()
        {
            RoadWorkList.Items.Clear();
            foreach (var work in RoadWork.RoadWorkList)
            {
                if (work is RoadWork && !(work is SeasonRoadWork))
                {
                    RoadWorkList.Items.Add(work);
                }
            }

            SeasonWorkList.Items.Clear();
            foreach (var work in RoadWork.RoadWorkList.OfType<SeasonRoadWork>())
            {
                SeasonWorkList.Items.Add(work);
            }
        }

        private void AddBaseWork_Click(object sender, EventArgs e)
        {
            try {
                if (tbWidth != null && tbLength != null && tbMass != null)
                {
                    double width = double.Parse(tbWidth.Text);
                    double length = double.Parse(tbLength.Text);    
                    double mass = double.Parse(tbMass.Text);    

                    var work = new RoadWork(width, length, mass);
                    work.AddToList();
                    baseInfo.Text = work.GetInfo();

                    UpdateLists();
                }
                else MessageBox.Show("Odfbbh");
            }
            catch {
                MessageBox.Show("Ops!");
            }
        }

        private void AddSeasonWork_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbWidth != null && tbLength != null && tbMass != null && tbMonth != null)
                {
                    double width = double.Parse(tbWidth.Text);
                    double length = double.Parse(tbLength.Text);
                    double mass = double.Parse(tbMass.Text);
                    int month = int.Parse(tbMonth.Text);

                    var work = new SeasonRoadWork(width, length, mass, month);
                    work.AddToList();
                    childInfo.Text = work.GetInfo();

                    UpdateLists();
                }
                else MessageBox.Show("Odfbbh");
            }
            catch
            {
                MessageBox.Show("Ops!");
            }
        }

        //удаление выбранных базовых объектов 
        private void removeBase_Click(object sender, EventArgs e)
        {
            if (RoadWorkList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите объекты для удаления");
                return;
            }

            var selected = new List<RoadWork>();
            foreach (var item in RoadWorkList.SelectedItems)
            {
                if (item is RoadWork work)
                    selected.Add(work);
            }

            RoadWork.RemoveFromList(selected);
            UpdateLists();
        }

        //удаление выбранных сезонных объектов
        private void removeChild_Click(object sender, EventArgs e)
        {
            if (SeasonWorkList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите объекты для удаления");
                return;
            }

            var selected = new List<RoadWork>();
            foreach (var item in SeasonWorkList.SelectedItems)
            {
                if (item is SeasonRoadWork work)
                    selected.Add(work);
            }

            RoadWork.RemoveFromList(selected);
            UpdateLists();

        }
    }
}
