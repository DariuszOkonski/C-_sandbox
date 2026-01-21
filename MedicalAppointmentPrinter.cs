namespace SandBox
{
    internal class MedicalAppointmentPrinter
    {
        public void Print(MedicalAppointment medicalAppointment)
        {
            Console.WriteLine("Appointment will take place on: " + medicalAppointment.GetDate());
        }
    }
}
