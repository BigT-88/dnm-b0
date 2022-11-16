namespace BugListViewMidTruncDemo;

public partial class MainPage : ContentPage 
{
    private List<FileDocument> _documents = new List<FileDocument>();
    public List<FileDocument> Documents
    {
        get { return _documents; }
        set
        {
            _documents = value;
            OnPropertyChanged();
        }
    }

    public MainPage()
    {
        InitializeComponent();

        LoadDocuments();
        this.BindingContext = this;
    }

    private void LoadDocuments()
    {
        _documents.Add(new FileDocument { FileName = "yetstillfilehasaverylongname98765432100123456789.jpg", FileSize = "108KB" });
        _documents.Add(new FileDocument { FileName = "sothenthisfilehasaverylongname98765432100123456789.jpg", FileSize = "3MB" });
        _documents.Add(new FileDocument { FileName = "anotherfilehasaverylongname98765432100123456789.jpg", FileSize = "357KB" });
        _documents.Add(new FileDocument { FileName = "shortname.jpg", FileSize = "233KB" });
        _documents.Add(new FileDocument { FileName = "andmorefilehasaverylongname98765432100123456789.jpg", FileSize = "93KB" });
        _documents.Add(new FileDocument { FileName = "eventhisfilehasaverylongname98765432100123456789.jpg", FileSize = "444KB" });
    }
}

public class FileDocument
{
	public string FileName { get; set; }
	public string FileSize { get; set; }
}