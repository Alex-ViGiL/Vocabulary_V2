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

namespace Vocabulary_v._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
         

            
        }

        private void Add_to_vocabulary(object sender, RoutedEventArgs e)
        {



            string add_word = addWord.Text;

            string add_translat = addTranslat.Text;

            Word word = new Word(add_word,add_translat);

            db.Words.Add(word);
            db.SaveChanges();

            addTranslat.Text = "";
            addWord.Text = "";

        }
    }
}
