using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Xml;

namespace WinFormsNewPeer9
{
    public partial class Form1 : Form
    {
        // Product list. 
        public List<Product> products = new List<Product>();
        TreeNode firstTreeNode;
        Product newProduct;
        private StreamWriter sr;
        // File where the condition of the programme will be recorded.
        string filename = "Data.xml";
        TreeNode selectedNode;
        List<string> csvList = new List<string>();

        /// <summary>
        /// Getting treeView1.
        /// </summary>
        /// <returns> treeView </returns>
        public TreeView GetTree()
        {
            return treeView1;
        }

        public Form1()
        {
            InitializeComponent();
            // Reconstruct a programme's condition from a file.
            if (File.Exists("Data.xml"))
            {
                try
                {
                    ReadXml();
                }
                catch (Exception)
                {
                    treeView1.Nodes.Clear();
                    firstTreeNode = new TreeNode("Склад");
                    treeView1.Nodes.Add(firstTreeNode);
                    MessageBox.Show("Неправильный файл для считывания");
                }
            }
            else
            {
                firstTreeNode = new TreeNode("Склад");
                treeView1.Nodes.Add(firstTreeNode);
            }
        }


        /// <summary>
        /// Xml serialization.
        /// </summary>
        /// <param name="tv"> TreeView element </param>
        /// <param name="filename"> file name </param>
        public void XmlSerialisation(TreeView tv, string filename = "Data.xml")
        {
            try
            {
                sr = new StreamWriter(filename, false, System.Text.Encoding.UTF8);
                // Write the header.
                sr.WriteLine(@"<?xml version=""1.0"" encoding=""utf-8"" ?>");
                // Write our root node.
                sr.WriteLine("<" + treeView1.Nodes[0].Text + ">");
                foreach (TreeNode node in tv.Nodes)
                {
                    SaveNode(node.Nodes);
                }
                // Close the root node.
                sr.WriteLine("</" + treeView1.Nodes[0].Text + ">");
                sr.Close();
            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// Saving a tree branch.
        /// </summary>
        /// <param name="tnc"> collection of tree branches </param>
        private void SaveNode(TreeNodeCollection tnc)
        {
            foreach (TreeNode node in tnc)
            {
                if (node.Nodes.Count > 0)
                {
                    sr.WriteLine("<" + "_" + node.Text + ">");
                    if (node.Tag != null)
                    {
                        List<Product> productList = ((List<Product>)node.Tag);
                        foreach (var product in productList)
                        {
                            sr.WriteLine("<_product>");
                            sr.WriteLine($"{product.Title};{product.Code};{product.Company};{product.Country};{product.YNK};" +
                                $"{product.Amount};{product.Price1};{product.Price2};{product.Price3};{product.Price4};" +
                                $"{product.Currency};{product.Guarantee};{product.SpecialOffer};{product.Status};" +
                                $"{product.UnitOfMeasure};{product.Link}");
                            sr.WriteLine("</_product>");
                        }
                    }
                    SaveNode(node.Nodes);
                    sr.WriteLine("</" + "_" + node.Text + ">");
                }
                else
                {
                    sr.WriteLine("<" + "_" + node.Text + ">");
                    if (node.Tag != null)
                    {
                        List<Product> productList = ((List<Product>)node.Tag);
                        foreach (var product in productList)
                        {
                            sr.WriteLine("<_product>");
                            sr.WriteLine($"{product.Title};{product.Code};{product.Company};{product.Country};{product.YNK};" +
                                $"{product.Amount};{product.Price1};{product.Price2};{product.Price3};{product.Price4};" +
                                $"{product.Currency};{product.Guarantee};{product.SpecialOffer};{product.Status};" + $"{product.UnitOfMeasure};{product.Link}");
                            sr.WriteLine("</_product>");
                        }
                    }
                    sr.WriteLine("</" + "_" + node.Text + ">");
                }

            }
        }

        /// <summary>
        /// Reading an xml file.
        /// </summary>
        public void ReadXml()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filename);
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(new TreeNode(xDoc.DocumentElement.Name));
            TreeNode tNode = new TreeNode();
            tNode = (TreeNode)treeView1.Nodes[0];
            NewNode(xDoc.DocumentElement, tNode);
            treeView1.ExpandAll();
        }

        /// <summary>
        /// Creating a branch.
        /// </summary>
        /// <param name="xmlNode"> branch from the file </param>
        /// <param name="treeNode"> branch </param>
        private void NewNode(XmlNode xmlNode, TreeNode treeNode)
        {
            try
            {
                List<Product> listProducts = new List<Product>();
                XmlNode xNode;
                TreeNode tNode;
                XmlNodeList xNodeList;
                int k = 0;
                if (xmlNode.HasChildNodes)
                {
                    xNodeList = xmlNode.ChildNodes;
                    for (int i = 0; i <= xNodeList.Count - 1; i++)
                    {
                        if (xmlNode.ChildNodes[i].Name == "_product")
                        {
                            List<string> list = xmlNode.ChildNodes[i].InnerText.Split(";").ToList();
                            for (int j = 0; j < list.Count; j++)
                            {
                                list[j] = list[j].Trim();
                            }
                            listProducts.Add(new Product(list[0], list[1], list[2], list[3], list[4], int.Parse(list[5]),
                            double.Parse(list[6]), double.Parse(list[7]), double.Parse(list[8]), double.Parse(list[9]),
                            list[10], list[11], list[12], list[13], list[14], list[15]));
                            k++;
                        }
                        else
                        {
                            xNode = xmlNode.ChildNodes[i];
                            treeNode.Nodes.Add(new TreeNode(xNode.Name.Substring(1, xNode.Name.Length - 1)));
                            tNode = treeNode.Nodes[i - k];


                            NewNode(xNode, tNode);
                        }
                        treeNode.Tag = listProducts;
                    }

                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Button to add a section.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPartitions_Click(object sender, EventArgs e)
        {
            Sections sections = new Sections();
            sections.Set(this);
            sections.Show();
        }

        /// <summary>
        /// Method for adding a branch.
        /// </summary>
        /// <param name="nameNew"> branch name </param>
        public void ApplyForm1(string nameNew)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            string name = nameNew;
            TreeNodeCollection node;
            TreeNode treeNode = new TreeNode(name);
            if (selectedNode == null)
                node = GetTree().Nodes;
            else
                node = selectedNode.Nodes;
            if (name.Trim() == "")
            {
                MessageBox.Show("Введенное название раздела некорректно, введите другое");
                return;
            }
            for (int i = 0; i < node.Count; i++)
            {
                if (node[i].Text == name)
                {
                    MessageBox.Show("Такое название уже существует, укажите другое :)");
                    return;
                }
            }
            node.Add(treeNode);

        }

        /// <summary>
        /// Product creation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreatingProducts_Click(object sender, EventArgs e)
        {
            Product product = null;
            FormInfo infoForm = new FormInfo();
            selectedNode = treeView1.SelectedNode;
            if ((selectedNode == firstTreeNode || selectedNode.Text == "Склад"))
            {
                MessageBox.Show(@"Вы не можете добавлять продукты в раздел ""Склад""");
                return;
            }
            infoForm.Set(this, product, null, null);
            infoForm.Show();

        }


        /// <summary>
        /// Adding a product to a section.
        /// </summary>
        /// <param name="product"> product </param>
        public void AddProduct(Product product, TreeNode select)
        {
            newProduct = product;
            if (select != null)
                selectedNode = select;

            if (newProduct.Title.Trim() == "")
            {
                MessageBox.Show("Введенное название продукта некорректно, введите другое");
                return;
            }
            try
            {
                if (selectedNode == null)
                    return;
                if (selectedNode.Tag == null)
                {
                    List<Product> list = new List<Product>();
                    list.Add(newProduct);
                    selectedNode.Tag = list;
                }
                else
                {
                    List<Product> productListCheck = ((List<Product>)selectedNode.Tag);
                    for (int i = 0; i < productListCheck.Count; i++)
                    {
                        if (productListCheck[i].Title == newProduct.Title)
                        {
                            MessageBox.Show("Введенное название продукта некорректно, введите другое");
                            return;
                        }
                    }
                    ((List<Product>)selectedNode.Tag).Add(newProduct);
                }
            }
            catch (Exception)
            { }

        }


        private void Form1_Load(object sender, EventArgs e)
        { }


        /// <summary>
        /// Deletion of either the section or the product.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeletion_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            TreeNode nodeRight = treeViewText.SelectedNode;
            if (treeViewText.SelectedNode != null)
            {
                if (nodeRight != null && selectedNode != null)
                {
                    List<Product> productsList = ((List<Product>)selectedNode.Tag);
                    if (productsList == null)
                        return;
                    for (int i = 0; i < productsList.Count; i++)
                    {
                        if (productsList[i].Title == nodeRight.Text)
                        {
                            productsList.Remove(productsList[i]);
                            treeViewText.Nodes.Remove(nodeRight);
                            break;
                        }
                    }
                }
            }
            else if (treeView1.SelectedNode != null)
            {
                if (selectedNode.Text == "Склад")
                {
                    MessageBox.Show(@"Удалить раздел ""Склад"" нельзя");
                    return;
                }
                if (selectedNode.Nodes.Count >= 1 || ((List<Product>)selectedNode.Tag) != null)
                {
                    if (((List<Product>)selectedNode.Tag).Count == 0 && selectedNode.Nodes.Count == 0)
                    {
                        treeView1.Nodes.Remove(selectedNode);
                        return;
                    }
                    MessageBox.Show("Непустой раздел");
                    return;
                }


                if ((selectedNode != null) && (selectedNode != firstTreeNode))
                    treeView1.Nodes.Remove(selectedNode);
            }
        }


        /// <summary>
        /// Change either the section or the product.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Change_Click(object sender, EventArgs e)
        {
            TreeNode node;
            if (treeViewText.SelectedNode != null)
            {
                TreeNode nodeLeft = treeView1.SelectedNode;
                TreeNode nodeRight = treeViewText.SelectedNode;
                FormInfo formInfo = new FormInfo();
                formInfo.Set(this, null, nodeLeft, nodeRight);
                formInfo.Show();
                MessageBox.Show("После изменения продуктов нажмите еще раз на исходный раздел, чтобы увидеть изменения");
            }
            else if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Text == "Склад")
                {
                    MessageBox.Show(@"Вы не можете изменять раздел ""Склад""");
                    return;
                }
                node = treeView1.SelectedNode;
                Sections sections = new Sections();
                sections.SectionSetNode(node);
                sections.Show();
            }
        }


        private void Form1_Closed(Object sender, FormClosedEventArgs e)
        {
            // Serialisation before closing.
            XmlSerialisation(treeView1, filename);
        }


        private void Select(object sender, MouseEventArgs e)
        {
            treeViewText.SelectedNode = null;
            CreatingProducts.Enabled = true;
            buttonPartitions.Enabled = true;
            button_info.Enabled = false;
            TreeNode selectedNode = treeView1.SelectedNode;
            List<Product> list = new List<Product>();
            treeViewText.Nodes.Clear();
            if (selectedNode == null)
                return;
            if (selectedNode.Tag != null)
            {
                list = ((List<Product>)selectedNode.Tag);
            }
            else
            {
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                TreeNode treeNode = new TreeNode(list[i].Title);
                treeViewText.Nodes.Add(treeNode);
            }
        }

        private void DisappearedSelected(object sender, MouseEventArgs e)
        {
            CreatingProducts.Enabled = false;
            buttonPartitions.Enabled = false;
            button_info.Enabled = true;
        }

        /// <summary>
        /// Display product information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_info_Click(object sender, EventArgs e)
        {
            try
            {
                Product currentProduct = new Product();
                TreeNodeCollection node = treeViewText.Nodes;
                TreeNode selectedNodeLeft = treeView1.SelectedNode;
                TreeNode selectedNodeCurrent = treeViewText.SelectedNode;
                if (selectedNodeLeft == null)
                    return;
                List<Product> productListCheck = ((List<Product>)selectedNodeLeft.Tag);
                if (productListCheck == null)
                    return;
                for (int i = 0; i < productListCheck.Count; i++)
                {
                    if (selectedNodeCurrent.Text == productListCheck[i].Title)
                    {
                        currentProduct = productListCheck[i];
                    }
                }

                MessageBox.Show(currentProduct.ToString());
            }
            catch { }
        }


        /// <summary>
        /// Assignment of the path.
        /// </summary>
        /// <param name="path"> path </param>
        public void SetPath(string path)
        {
            try
            {
                if (path != "")
                {
                    path += ".xml";
                    XmlSerialisation(treeView1, path);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("У Вас проблемы с путем :( ");
            }
            openFileDialog1.Title = "Выберите xml файл, чтобы просмотреть его";
            openFileDialog1.Filter = "XML Files|*.xml";
            // Exit if "cancel" and others (except "OK") have been pressed.
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            // The file name is now stored in openFileDialog1.FileName.
            filename = openFileDialog1.FileName;
            if (File.Exists(filename))
            {
                try
                {
                    ReadXml();
                }
                catch (Exception)
                {
                    treeView1.Nodes.Clear();
                    firstTreeNode = new TreeNode("Склад");
                    treeView1.Nodes.Add(firstTreeNode);
                    MessageBox.Show("Неправильный файл для считывания");
                }
            }
        }


        /// <summary>
        /// Saves the current state of the programme to a file and then opens a new file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OpenAndSave_Click(object sender, EventArgs e)
        {
            FileName fileName = new FileName();
            fileName.SetFile(this);
            fileName.Show();

        }


        /// <summary>
        /// Creating a csv-report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_csv_Click(object sender, EventArgs e)
        {
            TreeNodeCollection node = GetTree().Nodes;
            PrintRecursive(node[0]);
            WriteCSV();
        }


        /// <summary>
        /// Create a report.
        /// </summary>
        public void WriteCSV()
        {
            if (csvList.Count == 0)
            {
                MessageBox.Show("Список товаров, вошедших в отчет, пуст ");
                return;
            }
            // Specify the path to the csv file.
            string pathCsvFile = "csvData.csv";
            // Add the test data to be written to the csv file.
            using (StreamWriter streamWriter = new StreamWriter(pathCsvFile, false, Encoding.UTF8))
            {
                streamWriter.WriteLine("<Путь_классификатора>" + ";" + "Артикул" +
                        ";" + "Название товара" + ";" + "Количество на складе");
                foreach (var x in csvList)
                {
                    streamWriter.WriteLine(x);
                }
            }
            MessageBox.Show("Csv-отчет находится в -> bin-> Debug->\"csvData.csv\" \n Для справки:" +
                " в отчет попадает товар, если он заканчивается. Вся информация в карточке товара.");
        }


        /// <summary>
        /// Filling the csvList with data.
        /// </summary>
        /// <param name="treeNode"> branch </param>
        private void PrintRecursive(TreeNode treeNode)
        {
            if (treeNode.Tag != null)
            {
                List<Product> productList = ((List<Product>)treeNode.Tag);
                for (int i = 0; i < productList.Count; i++)
                {
                    if (productList[i].Amount < productList[i].Price4)
                    {
                        csvList.Add(treeNode.FullPath.Trim() + ";" + productList[i].Code.Trim() +
                            ";" + productList[i].Title.Trim() + ";" + productList[i].Amount.ToString().Trim());
                    }
                }
            }
            foreach (TreeNode tn in treeNode.Nodes)
            {
                PrintRecursive(tn);
            }
        }

        /// <summary>
        /// Button for random filling.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            FormRandom formRandom = new FormRandom();
            formRandom.SetForm1(this);
            formRandom.Show();
        }

        /// <summary>
        /// Generate a random string.
        /// </summary>
        /// <returns> string </returns>
        public string RandomGenerate()
        {
            string res = String.Empty;
            Random rnd = new Random();
            int length = rnd.Next(5, 14);
            while (res.Length < length)
            {
                char c = (char)rnd.Next(33, 125);
                if (char.IsLetterOrDigit(c))
                    res += c;
            }
            return res;
        }

        /// <summary>
        /// Filling sections and products.
        /// </summary>
        /// <param name="amountOfSections"> amount of sections </param>
        /// <param name="amountOfProducts"> amount of products </param>
        public void Random(int amountOfSections, int amountOfProducts)
        {
            int countProduct = 0;
            Random rnd = new Random();
            treeView1.Nodes.Clear();
            firstTreeNode = new TreeNode("Склад");
            treeView1.Nodes.Add(firstTreeNode);
            for (int i = 0; i < amountOfSections; i++)
            {
                TreeNode treeNode;
                int index = firstTreeNode.Nodes.Count;
                if (index != 0)
                {
                    if (rnd.Next(0, 2) == 0)
                    {
                        int n = rnd.Next(index);
                        TreeNode current = firstTreeNode.Nodes[n];
                        treeNode = new TreeNode(RandomGenerate());
                        current.Nodes.Add(treeNode);
                    }
                    else
                    {
                        treeNode = new TreeNode(RandomGenerate());
                        firstTreeNode.Nodes.Add(treeNode);
                    }
                }
                else
                {
                    treeNode = new TreeNode(RandomGenerate());
                    firstTreeNode.Nodes.Add(treeNode);
                }
                if (countProduct < amountOfProducts)
                {
                    if (i == amountOfSections - 1)
                    {
                        int ost = amountOfProducts - countProduct;
                        for (int j = 0; j < ost; j++)
                        {
                            Product product = RandomProduct();
                            AddProduct(product, treeNode);
                        }
                    }
                    else
                    {
                        Product product = RandomProduct();
                        AddProduct(product, treeNode);
                        countProduct++;
                    }
                }
            }
        }

        /// <summary>
        /// Create an product at random.
        /// </summary>
        /// <returns> product </returns>
        public Product RandomProduct()
        {
            Random rnd = new Random();
            Product product = new Product(RandomGenerate(), RandomGenerate(), RandomGenerate(), RandomGenerate(), RandomGenerate(),
                rnd.Next(0, 20), rnd.NextDouble() + rnd.Next(0, 500), rnd.NextDouble() + rnd.Next(0, 500), rnd.NextDouble() + rnd.Next(0, 500),
                rnd.Next(0, 20), RandomGenerate(), RandomGenerate(), RandomGenerate(), RandomGenerate(), RandomGenerate(), RandomGenerate());
            return product;
        }

    }
}
