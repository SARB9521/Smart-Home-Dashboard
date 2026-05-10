namespace SmartHomeMVC.Models
{
    public class SmartHomeModel
    {
        public bool IsLightOn { get; set; }
        public bool IsFanOn { get; set; }
        public int Temperature { get; set; }
        public string RoomStatus { get; set; } = "Empty";
    }
}
