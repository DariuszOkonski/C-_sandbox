namespace SandBox.Other
{
    internal class MedicalAppointment
    {
        private string _patientName;
        private DateTime _date;

        public MedicalAppointment(string patientName, DateTime date)
        {
            _patientName = patientName;
            _date = date;
        }

        //public MedicalAppointment(string patientName) :
        //    this(patientName, 7)
        //{ }

        public MedicalAppointment(string patientName = "Unknown", int daysFromNow = 7)
        {
            _patientName = patientName;
            _date = DateTime.Now.AddDays(daysFromNow);
        }

        public MedicalAppointment(string patientName)
        {
            _patientName = patientName;
        }

        public void OverwriteMonthAndDay(DateTime date)
        {
            _date = date;
        }

        public void MoveByMonthsAndDays(int month, int day)
        {
            _date = new DateTime(_date.Year, month, day);
        }

        public void Reschedule(DateTime date)
        {
            _date = date;
            var printer = new MedicalAppointmentPrinter();
            printer.Print(this);
        }

        public DateTime GetDate() => _date;
    }
}
