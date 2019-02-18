using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DicasXamariniOS
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Property

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion

        public ObservableCollection<User> Users { get; }

        private int _rating;
        public int Rating
        {
            get { return _rating; }
            set => SetProperty(ref _rating, value);
        }

        public MainViewModel()
        {
            Users = new ObservableCollection<User>();

            Users.Add(new User {
                Name = "Bertuzzi"
        });

            Users.Add(new User
            {
                Name = "Bruna"
            });

            Users.Add(new User
            {
                Name = "Polly"
            });

            Users.Add(new User
            {
                Name = "Rodolfo"
            });

            Users.Add(new User
            {
                Name = "Lester"
            });

        }


    }
}
