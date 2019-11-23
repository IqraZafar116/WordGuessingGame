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
    public partial class Form1 : Form
    {
        BinaryTree FruitsTree = new BinaryTree();
        BinaryTree VegetableTree = new BinaryTree();
        BinaryTree animalTree = new BinaryTree();
        BinaryTree birdTree = new BinaryTree();
        BinaryTree elementsTree = new BinaryTree();
        string randword = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void loadDic(BinaryTree tree,string filename)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDic(FruitsTree, "Fruits.txt");
            loadDic(VegetableTree, "Vegetables.txt");
            loadDic(animalTree, "Birds.txt");
            loadDic(birdTree, "Animals.txt");
            loadDic(elementsTree, "elements.txt");
            int randTreeValue=randomNumber(0,4);
            if (randTreeValue == 1)
                randword = "Fruits.getTreeIndex(randindex)";
            if (randTreeValue == 2)
                randword = "Vegetables.getTreeIndex(randindex)";
            if (randTreeValue == 3)
                randword = "Birds.getTreeIndex(randindex)";
            if (randTreeValue == 4)
                randword = "Animals.getTreeIndex(randindex)";
            else
                randword = "elements.getTreeIndex(randindex)";

        }
    }
}
