namespace PureFunctionsVsSideEffects;

// Kamera przemysłowa która robi zdjęcie i zapamiętuje nazwę ostatniego zdjęcia z numerem sekwencyjnym i ze znacznikiem czasu
// TODO: Musimy to sprawdzić!


public class IndustrialCamera
{
    private int _sequence = 0;

    public string LastCapturedImage { get; private set; }

    public void TakePicture()
    {
        _sequence++;

        string timestamp = DateTime.UtcNow.ToString("yyyyMMdd_HHmmss");
        LastCapturedImage = $"img_seq_{_sequence:D4}_{timestamp}.jpg";

        // Przykład: img_seq_0001_20250524_193201.jpg

        // Tu zapis zdjęcia:
        // CaptureImageToStorage(LastCapturedImage);
    }
}
