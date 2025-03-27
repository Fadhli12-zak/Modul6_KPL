
class SayaTubeUser {
    private int id;
    private List<SayaTubeVideo> UploadedVideos;
    public string Username;
    public SayaTubeUser( string username)
    {
        Random random = new Random();
        this.id = random.Next();
        this.Username = username;
        this.UploadedVideos = new List<SayaTubeVideo>();
    }
    public int GetTotalVideoCount()
    {
        return this.UploadedVideos.Count;
    }
    public void AddVideo(string title)
    {
        SayaTubeVideo video = new SayaTubeVideo( title);
        this.UploadedVideos.Add(video);
    }
    public void PrintAllVideoPlayCounts()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < this.UploadedVideos.Count; i++)
        {
          Console.WriteLine($"Video {i+1}: {UploadedVideos[i].title}");
          Console.WriteLine($"playCount {i + 1}: {UploadedVideos[i]}");
        }
    }
}

class SayaTubeVideo
{
    private int id;
    public String title;
    public int playCount;
    public SayaTubeVideo( string title)
    {
        Random random = new Random();
        this.id = random.Next();
        this.title = title;
        this.playCount = 0;
    }
    public void increasePlayCount()
    {
        this.playCount++;
    }
    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID: " + this.id);
        Console.WriteLine("Video Title: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount);
    }
}

class main {
    public static void Main(String[] args)
    {
        SayaTubeUser user = new SayaTubeUser( "fadhli");
        user.AddVideo("review film interstellar oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Narcos oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Better Call Saul oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Breaking bad oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Moana oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film la la land oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Black Panther oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Avengers oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Moon Knight oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Spirit away oleh Fadhli Muhammad Dzaki");
        user.PrintAllVideoPlayCounts();

        Console.WriteLine();
        Console.WriteLine("=====================================");
        SayaTubeVideo video1 = new SayaTubeVideo("review film interstellar oleh Fadhli Muhammad Dzaki");
        video1.increasePlayCount();
        video1.PrintVideoDetails();
    }

}