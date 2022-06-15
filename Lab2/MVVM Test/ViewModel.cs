using Lab2dll;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MVVM_Test
{
    internal class ViewModel : INotifyPropertyChanged
    {
        Tour selectedTour;
        Excursion selectedExcursion;

        IFileService fileService;
        IDialogService dialogService;

        public ObservableCollection<Tour> Tours { get; set; }

        private RelayCommand saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand ??
                  (saveCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (dialogService.SaveFileDialog() == true)
                          {
                              fileService.Save(dialogService.FilePath, Tours.ToList());
                              dialogService.ShowMessage("File saved");
                          }
                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }
                  }));
            }
        }

        private RelayCommand openCommand;
        public RelayCommand OpenCommand
        {
            get
            {
                return openCommand ??
                  (openCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (dialogService.OpenFileDialog() == true)
                          {
                              var tour = fileService.Open(dialogService.FilePath);
                              Tours.Clear();
                              foreach (var p in tour)
                                  Tours.Add(p);
                          }
                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }
                  }));
            }
        }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Tour tour = new Tour(RndGenerator.RndCost(), RndGenerator.RndDay(), RndGenerator.RndListExcurs(5));
                      Tours.Insert(0, tour);
                      SelectedTour = tour;
                  }));
            }
        }

        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                    (removeCommand = new RelayCommand(obj =>
                    {
                        Tour tour = obj as Tour;
                        if (tour != null)
                        {
                            Tours.Remove(tour);
                        }
                    },
                    (obj) => Tours.Count > 0 && selectedTour != null));
            }
        }

        /*private RelayCommand closeCommand;
        public RelayCommand CloseCommand
        {
            get
            {
                return closeCommand ??
                    (closeCommand = new RelayCommand(obj =>
                    {
                        Window window = obj as Window;
                        if (changes)
                        {
                            string msg = "Changes not saved. Close without saving?";
                            MessageBoxResult result = MessageBox.Show(msg, "Data App", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                        }
                    }));
            }
        }*/

        private RelayCommand listElement;
        public RelayCommand ListElement
        {
            get
            {
                return listElement ??
                    (listElement = new RelayCommand(obj =>
                    {
                        Excursion excursion = obj as Excursion;
                        if (excursion != null)
                        {
                            Form window = new Form();
                            window.ShowDialog();
                            selectedExcursion = excursion;
                        }
                    },
                    (obj) => selectedExcursion != null));
            }
        }

        public Tour SelectedTour
        {
            get { return selectedTour; }
            set
            {
                selectedTour = value;
                OnPropertyChanged("SelectedTour");
            }
        }

        public Excursion SelectedExcursion
        {
            get { return selectedExcursion; }
            set
            {
                selectedExcursion = value;
                OnPropertyChanged("SelectedExcursion");
            }
        }

        public ViewModel(IDialogService dialogService, IFileService fileService)
        {
            this.dialogService = dialogService;
            this.fileService = fileService;

            Tours = new ObservableCollection<Tour>
            {
                new Tour(RndGenerator.RndCost(),RndGenerator.RndDay(),RndGenerator.RndListExcurs(6)),
                new Tour(RndGenerator.RndCost(),RndGenerator.RndDay(),RndGenerator.RndListExcurs(6)),
                new Tour(RndGenerator.RndCost(),RndGenerator.RndDay(),RndGenerator.RndListExcurs(6)),
                new Tour(RndGenerator.RndCost(),RndGenerator.RndDay(),RndGenerator.RndListExcurs(6))
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}