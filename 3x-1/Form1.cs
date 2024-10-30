using System.Windows.Forms.DataVisualization.Charting;


namespace _3x_1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void run_Click(object sender, EventArgs e)
        {
            string inputValue =  inputBox.Text;
            string[] inputNumbers = inputValue.Split(',');
            List<int> nodes1 = [];
            List<Line> lines = [];

            //Process input
            foreach (var n in inputNumbers)
            {
                bool success = int.TryParse(n, out int number);
                if (success && number > 0 && number % 1 == 0) {

                    if (!nodes1.Contains(number))
                    {
                        errorLabel.Visible = false;
                        nodes1.Add(number);
                        
                    }
                }
                else
                {
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Visible = true;
                    return;
                }
            }

            if (nodes1.Count() > 0)
            {
                //Clear list window
                listView.Items.Clear();

                //Make lines of of the input data
                foreach (var item in nodes1)
                {
                    List<int> ns = getNodes(item);
                    Line line = new(item, findPeakNumber(ns), ns.Count(), ns);
                    lines.Add(line);
                }



                //Config the list
                listView.Columns.Clear();
                listView.View = View.Details;
                listView.Columns.Add(new ColumnHeader { Text = "Number",TextAlign = HorizontalAlignment.Left, Width =  listView.Width / 3 });
                listView.Columns.Add(new ColumnHeader { Text = "Peak", TextAlign = HorizontalAlignment.Center, Width = listView.Width / 3 });
                listView.Columns.Add(new ColumnHeader { Text = "Length", TextAlign = HorizontalAlignment.Right, Width = listView.Width / 3 });
                

                //Populate the list 
                foreach (var line in lines)
                {
                    string[] row = { $"{line.Id}", $"{line.Peak}", $"{line.Length}" };
                    var listViewItem = new ListViewItem(row);
                    listView.Items.Add(listViewItem);
                }

                //Reset or instantiate the chart
                configureChart();

                //Fill up the chart
                foreach(Line line in lines)
                {
                    drawLine(line);
                }

            }

            void configureChart()
            {
                myChart.Series.Clear();


            }
            void drawLine(Line line)
            {
                Series series = new Series($"{line.Id}")
                {
                    ChartType = SeriesChartType.Line
                };

                myChart.Series.Add(series);

                for (int i = 0; i < line.Nodes.Count; i++)
                {
                    myChart.Series[$"{line.Id}"].Points.AddXY(i + 1, line.Nodes[i]);
                }
            }

            List<int> getNodes(int start)
            {
                //Return list
                List<int> resultList = [];
                int result = start;


                while (result != 1)
                {
                    //If number is even do  x / 2 and run function again for the result
                    if (result % 2 == 0)
                    {
                        result = result / 2;
                        resultList.Add(result);

                    }

                    //If number is odd do 3x + 1 and run function again for the result
                    else if (result % 2 != 0)
                    {
                        result = result * 3 + 1;
                        resultList.Add(result);
                    }
                }

                return resultList;

            }

            int findPeakNumber(List<int> numbers)
            {
                int peakNumber = 0;
                foreach (var number in numbers)
                {
                    if (number > peakNumber)
                    {
                        peakNumber = number;
                    }
                }

                return peakNumber;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void firstNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorLabel.Visible = false; 
            myChart.Series.Clear();
            inputBox.PlaceholderText = "Put 11 or multiple numbers 3,24,9";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}


