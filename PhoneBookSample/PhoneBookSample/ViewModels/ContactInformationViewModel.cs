using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PhoneBookSample.Models;
using Xamarin.Forms;

namespace PhoneBookSample.ViewModels
{
    public class ContactInformationViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Contact> Contacts { get; set; }
        public Command ChangeAppearanceCommand{ get; set; }
        public Color BTNColor { get; set; } = Color.FromHex("#D3487E");
        public Color BGColor { get; set; } = Color.FromHex("#90E4F9"); 
        public ContactInformationViewModel()
        {
            ChangeAppearanceCommand= new Command(ChangeAppearance);
             
            Contacts = new ObservableCollection<Contact>
            {
                new Contact
                {
                    Name        = "Leomaris" ,
                    LastName    = "Reyes Rosario",
                    PhoneNumber = "8092223333",
                    Gender      = "Female"
                },
                new Contact
                {
                    Name        = "Jose" ,
                    LastName    = "Perez Lopez",
                    PhoneNumber = "8092215555",
                    Gender      = "Male"
                },
                new Contact
                {
                    Name        = "Maria" ,
                    LastName    = "Rodriguez Mendez",
                    PhoneNumber = "8293334445",
                    Gender      = "Female"
                }
            };

        }

        public void ChangeAppearance()
        {
                BTNColor = Color.FromHex("#AEA9FC");
                BGColor = Color.FromHex("#FCCBFD");
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}