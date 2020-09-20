using System;
using System.Collections.ObjectModel;

namespace ContextMenu.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<string> Items { get; } = new ObservableCollection<string>();

        public void Add() => Items.Add(DateTime.Now.ToString("O"));

        public void Remove()
        {
            if (Items.Count > 0)
                Items.RemoveAt(0);
        }

        public void MenuItemClicked() { }
    }
}
