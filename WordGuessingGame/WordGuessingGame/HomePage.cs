﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessingGame
{
    public partial class HomePage : Form
    {
        public BinaryTree FruitsTree = new BinaryTree();
        public BinaryTree VegetableTree = new BinaryTree();
        public BinaryTree animalTree = new BinaryTree();
        public BinaryTree birdTree = new BinaryTree();
        public BinaryTree elementsTree = new BinaryTree();
        public string randword = "";
        public string dashdoword = "";
        public HomePage()
        {
            InitializeComponent();
        }
        private void loadDic(BinaryTree tree, string filename)
        {
            string[] readText = File.ReadAllLines(filename);
            foreach (string x in readText)
            {
                tree.Insert(x);
            }
        }
        private int randomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void Insert_Click(object sender, EventArgs e)
        {
        }
        private string produceDashes(string word)
        {
            string temp = "";
            foreach (char x in word)
            {
                temp = temp + "_";
            }
            return temp;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadDic(FruitsTree, "Fruits.txt");
            loadDic(VegetableTree, "Vegetables.txt");
            loadDic(animalTree, "Birds.txt");
            loadDic(birdTree, "Animals.txt");
            loadDic(elementsTree, "elements.txt");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FruitsTree.insertChildrenCount(FruitsTree.root);
            VegetableTree.insertChildrenCount(VegetableTree.root);
            birdTree.insertChildrenCount(birdTree.root);
            elementsTree.insertChildrenCount(elementsTree.root);
            animalTree.insertChildrenCount(animalTree.root);
            int randTreeValue = randomNumber(0, 4);
            if (randTreeValue == 1)
                randword = FruitsTree.randomNode(FruitsTree.root);
            else if (randTreeValue == 2)
                randword = VegetableTree.randomNode(VegetableTree.root);
            else if (randTreeValue == 3)
                randword = birdTree.randomNode(birdTree.root);
            else if (randTreeValue == 4)
                randword = elementsTree.randomNode(elementsTree.root);
            else
                randword = animalTree.randomNode(animalTree.root);


            randword = randword.ToUpper();
            dashdoword = produceDashes(randword);
            //MessageBox.Show(dashdoword);
            GamePage gamepage = new GamePage(dashdoword, randword);
            gamepage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            helpPage helppage = new helpPage();
            helppage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}