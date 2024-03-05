using System;
class Solution2 {
    static string displayPeopleWhoLikesPost(string[] people){
        if(people.Length == 0){
            return "";
        }
        else if(people.Length == 1){
            return people[0]+" likes your post.";
        }
        else if(people.Length == 2){
            return people[0]+ " and " + people[1] + " like your post.";
        }
        else{
            return (people[0]+", "+people[1] +" and "+ (people.Length-2) + " others like your post.");
        }
        
    }
  static void Main() {
    string[] instance1 = {"Alpha", "Beta", "Gamma", "Delta"};
    Console.WriteLine(displayPeopleWhoLikesPost(instance1));

    string[] instance2 = {"Alpha", "Beta"};
    Console.WriteLine(displayPeopleWhoLikesPost(instance2));

    string[] instance3 = {"Alpha"};
    Console.WriteLine(displayPeopleWhoLikesPost(instance3));

    string[] instance4 = {};
    Console.WriteLine(displayPeopleWhoLikesPost(instance4));

    

    
    
  }
}