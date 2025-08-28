namespace DemoMVC.Models
{
    public class BMI
    {
        public double Height { get; set; }   // chiều cao (m)
        public double Weight { get; set; }   // cân nặng (kg)
        public double Result { get; set; }   // chỉ số BMI
        public string Category { get; set; } // phân loại
    }
}
