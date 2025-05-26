namespace TestingVoidMethods;

// Kamera przemysłowa która robi zdjęcie i zapamiętuje nazwę ostatniego zdjęcia z numerem sekwencyjnym
// TODO: Musimy to sprawdzić!

public class IndustrialCamera
{
    private int _sequence = 0;

    public string LastCapturedImage { get; private set; }

    public void TakePicture()
    {
        _sequence++;
        LastCapturedImage = $"img_seq_{_sequence:D4}.jpg";

        // Tutaj byłby kod do przechwytywania i zapisu zdjęcia, np. do dysku lub FTP
        // CaptureImageToStorage(LastCapturedImage);
    }
}
