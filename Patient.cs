using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace PriemPatient
{
    public class Patient : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private int _idP = 0;
        public int IdP
        {
            get => _idP;
            set
            {
                if (_idP != value)
                {
                    _idP = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _nameP = "";
        public string NameP
        {
            get => _nameP;
            set
            {
                if (_nameP != value)
                {
                    _nameP = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _lastnameP = "";
        public string LastNameP
        {
            get => _lastnameP;
            set
            {
                if (_lastnameP != value)
                {
                    _lastnameP = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _middlenameP = "";
        public string MiddleNameP
        {
            get => _middlenameP;
            set
            {
                if (_middlenameP != value)
                {
                    _middlenameP = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _lastAppointment = "";
        public string LastAppointment
        {
            get => _lastAppointment;
            set
            {
                if (_lastAppointment != value)
                {
                    _lastAppointment = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _birthday = "";
        public string Birthday
        {
            get => _birthday;
            set
            {
                if (_birthday != value)
                {
                    _birthday = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _diagnosisP = "";
        public string DiagnosisP
        {
            get => _diagnosisP;
            set
            {
                if (_diagnosisP != value)
                {
                    _diagnosisP = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _recomendationsP = "";
        public string RecomendationsP
        {
            get => _recomendationsP;
            set
            {
                if (_recomendationsP != value)
                {
                    _recomendationsP = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _phoneNumber = "";
        public string PhoneNumber
        {
            get => _phoneNumber;
            set { _phoneNumber = value; OnPropertyChanged(); }
        }

        private Appointment[] _appointmentStories = new Appointment[0];
        public Appointment[] AppointmentStories
        {
            get => _appointmentStories;
            set
            { 
                _appointmentStories = value; 
                OnPropertyChanged(); 
            }
        }
    }

    public class Appointment
    {
        public string Date { get; set; } = "";

        public int DoctorId { get; set; }

        public string Diagnosis { get; set; } = "";
        public string Recomendations { get; set; } = "";
    }
}
