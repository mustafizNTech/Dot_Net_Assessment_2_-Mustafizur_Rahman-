using System;
class Post {
  public string Title;
  public string Description;
  public DateTime CreationDate;
  private int voteValue;

  public Post(string title, string description){
    Title = title;
    Description = description;
    CreationDate = DateTime.Now;
    voteValue = 0;
  }

  public void upVote(){
    voteValue++;
  }

  public void downVote(){
    voteValue--;
  }

  public int getTotalVotes(){
    return voteValue;
  }
}

class Program{
  static void Main(string[] args){
    Post post = new Post("Post1", "This is description for Post1.");

    post.upVote();
    post.upVote();
    post.downVote();
    post.upVote();

    Console.WriteLine("Total vote: " + post.getTotalVotes());
  }
}