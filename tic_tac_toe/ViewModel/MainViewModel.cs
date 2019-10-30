using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using DevExpress.Mvvm;
using Newtonsoft.Json;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class MainViewModel
    {
        public int SelectedIndex { get; set; }
        public Item SeletedItem { get; set; }
        public ObservableCollection<Item> Items { get; set; }
        public MainViewModel()
        {
            Items = new ObservableCollection<Item>();

            Items.Add(new Item
            {
                ElementName = "H",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "He",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Li",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Be",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "B",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "C",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "N",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "O",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "F",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Ne",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Na",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Mg",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Al",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Si",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "P",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "S",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Cl",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Ar",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "K",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Ca",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Sc",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Ti",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "V",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Cr",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Mn",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Fe",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Co",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Ni",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Cu",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Zn",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Ga",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Ge",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "As",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Se",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Br",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Kr",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Rb",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Sr",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Y",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Zr",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Nb",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Mo",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Tc",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Ru",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Rh",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Pd",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Ag",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Cd",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "In",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Sn",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Sb",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Te",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "I",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Xe",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Cs",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Ba",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "La*",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Hf",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Ta",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "W",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Re",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Os",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Ir",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Pt",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Au",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Hg",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Ti",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Pb",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Bi",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Po",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "At",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Rn",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Fr",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Ra",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Ac**",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Db",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Jl",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Rf",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Bh",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Hn",
                IsMetal = false,
                IsSelected = false
            }); Items.Add(new Item
            {
                ElementName = "Mt",
                IsMetal = false,
                IsSelected = false
            });

            Items.CollectionChanged += (s, e) => { SeletedItem.IsSelected = true; };
        }


        
        public void Chekc()
        {
            string[] metals = Items.Where(u => u.IsMetal).Select(x => x.ElementName).ToArray();

            //Item[] selected = Items.Where(u => u.IsSelected).ToArray();

            //var rar = selected[0].IsSelected = false;
        }

        public ICommand GetCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var index = Items.IndexOf(SeletedItem);
                    Items[index] = SeletedItem;
                });
            }
        }
    }
}