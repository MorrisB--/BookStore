using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<BookStoreEntities>
    {
        protected override void Seed(BookStoreEntities context)
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Science Fiction" },
                new Genre { Name = "Poetry" },
                new Genre { Name = "Romance" },
                //new Genre { Name = "Mystery" },
                //new Genre { Name = "Literature" },
            };

            var authors = new List<Author>
            {
                new Author { Name = "Neal Stephenson" },
                new Author { Name = "J.R.R. Tolkien" },
                new Author { Name = "Joey Graceffa" },
                new Author { Name = "Richard Kadrey" },
                new Author { Name = "Ernest Cline" },
                new Author { Name = "Robin Cook" },
                new Author { Name = "Alethea Kontis" },
                new Author { Name = "Erika Johansen" },
                new Author { Name = "Cormac McCarthy" },
                new Author { Name = "Jordanna Max Brodsky" },
                new Author { Name = "Gwendolyn Womack" },
                new Author { Name = "S.K Dunstall" },
                new Author { Name = "Emily B. Martin" },
                new Author { Name = "Naomi Novik" },
                new Author { Name = "r.h. Sin" },
                new Author { Name = "Kahlil Gibran" },
                new Author { Name = "Edgar Allan Poe" },
                new Author { Name = "Samanth King" },
                new Author { Name = "Amanda  Lovelace" },
                new Author { Name = "Madisen Kuhn" },
                new Author { Name = "Land Leav" },
                new Author { Name = "Robert M. Drake" },
                new Author { Name = "Homer" },
                new Author { Name = "pleasefindthis" },
                new Author { Name = "Michael Faudet" },
                new Author { Name = "Dante" },
                new Author { Name = "Billy Collins" },
                new Author { Name = "Jayne Ann Krentz" },
                new Author { Name = "Barbara Freethy" },
                new Author { Name = "Lynn Austin" },
                new Author { Name = "Nora Roberts" },
                new Author { Name = "Sarah Morgan" },
                new Author { Name = "Karen Ranney" },
                new Author { Name = "Karen Harper" },
                new Author { Name = "Sharon Sala" },
                new Author { Name = "Amy Sandas" },
                new Author { Name = "Katie Ruggle" },
                new Author { Name = "Amanda Cabot" },
                new Author { Name = "Mary Balogh" },
                new Author { Name = "Maya Banks" },
                new Author { Name = "Sandra Brown" },
                new Author { Name = "Susan Mallery" },
            };

            new List <Book>
            {
                new Book { Title = "Seveneves", Genre = genres.Single(g => g.Name == "Science Fiction"), Price = 10.80M, Author = authors.Single(a => a.Name == "Neal Stephenson"), BookCoverUrl = "/Content/Images/BookCovers/ScienceFiction/Seveneves.jpg" },
                new Book { Title = "The Children of Hurin", Genre = genres.Single(g => g.Name == "Science Fiction"), Price = 8.99M, Author = authors.Single(a => a.Name == "J.R.R. Tolkien"), BookCoverUrl = "/Content/Images/BookCovers/ScienceFiction/TheChildrenOfHurin.jpg" },
                new Book { Title = "Children of Eden", Genre = genres.Single(g => g.Name == "Science Fiction"), Price = 11.36M, Author = authors.Single(a => a.Name == "Joey Graceffa"), BookCoverUrl = "/Content/Images/BookCovers/ScienceFiction/ChildrenOfEden.jpg" },
                new Book { Title = "The Everything Box: A Novel", Genre = genres.Single(g => g.Name == "Science Fiction"), Price = 24.10M, Author = authors.Single(a => a.Name == "Richard Kadrey"), BookCoverUrl = "/Content/Images/BookCovers/ScienceFiction/TheEverythingBox.jpg" },
                new Book { Title = "Ready Player One", Genre = genres.Single(g => g.Name == "Science Fiction"), Price = 9.78M, Author = authors.Single(a => a.Name == "Ernest Cline"), BookCoverUrl = "/Content/Images/BookCovers/ScienceFiction/ReadyPlayerOne.jpg" },
                new Book { Title = "Invasion", Genre = genres.Single(g => g.Name == "Science Fiction"), Price = 9.99M, Author = authors.Single(a => a.Name == "Robin Cook"), BookCoverUrl = "/Content/Images/BookCovers/ScienceFiction/Invasion.jpg" },
                new Book { Title = "Once Upon A Curse ", Genre = genres.Single(g => g.Name == "Science Fiction"), Price = 0.99M, Author = authors.Single(a => a.Name == "Alethea Kontis"), BookCoverUrl = "/Content/Images/BookCovers/ScienceFiction/OnceUponACurse.jpg" },
                new Book { Title = "The Queen of the Tearling ", Genre = genres.Single(g => g.Name == "Science Fiction"), Price = 18.82M, Author = authors.Single(a => a.Name == "Erika Johansen"), BookCoverUrl = "/Content/Images/BookCovers/ScienceFiction/TheQueenOfTheTearling.jpg" },
                new Book { Title = "The Road ", Genre = genres.Single(g => g.Name == "Science Fiction"), Price = 9.57M, Author = authors.Single(a => a.Name == "Cormac McCarthy"), BookCoverUrl = "/Content/Images/BookCovers/ScienceFiction/TheRoad.jpg" },
                new Book { Title = "The Immortals ", Genre = genres.Single(g => g.Name == "Science Fiction"), Price = 17.36M, Author = authors.Single(a => a.Name == "Jordanna Max Brodsky"), BookCoverUrl = "/Content/Images/BookCovers/ScienceFiction/theImmortals.jpg" },
                new Book { Title = "The Memory Painter ", Genre = genres.Single(g => g.Name == "Science Fiction"), Price = 14.68M, Author = authors.Single(a => a.Name == "Gwendolyn Womack"), BookCoverUrl = "/Content/Images/BookCovers/ScienceFiction/TheMemoryPainter.jpg" },
                new Book { Title = "Cryptonomicon ", Genre = genres.Single(g => g.Name == "Science Fiction"), Price = 8.99M, Author = authors.Single(a => a.Name == "Neal Stephenson"), BookCoverUrl = "/Content/Images/BookCovers/ScienceFiction/Crytonomicon.jpg" },
                new Book { Title = "Confluence", Genre = genres.Single(g => g.Name == "Science Fiction"), Price = 7.99M, Author = authors.Single(a => a.Name == "S.K Dunstall"), BookCoverUrl = "/Content/Images/BookCovers/ScienceFiction/Confluencee.jpg" },
                new Book { Title = "Woodwalker ", Genre = genres.Single(g => g.Name == "Science Fiction"), Price = 6.99M, Author = authors.Single(a => a.Name == "Emily B. Martin"), BookCoverUrl = "/Content/Images/BookCovers/ScienceFiction/Woodwalker.png" },
                new Book { Title = "Uprooted", Genre = genres.Single(g => g.Name == "Science Fiction"), Price = 11.52M, Author = authors.Single(a => a.Name == "Naomi Novik"), BookCoverUrl = "/Content/Images/BookCovers/ScienceFiction/Uprooted.jpg" },
                new Book { Title = "Rest in the Morning ", Genre = genres.Single(g => g.Name == "Poetry"), Price = 9.25M, Author = authors.Single(a => a.Name == "r.h. Sin"), BookCoverUrl = "/Content/Images/BookCovers/Poetry/RestInTheMorning.jpg" },
                new Book { Title = "The Prophet", Genre = genres.Single(g => g.Name == "Poetry"), Price = 11.28M, Author = authors.Single(a => a.Name == "Kahlil Gibran"), BookCoverUrl = "/Content/Images/BookCovers/Poetry/TheProphet.jpg" },
                new Book { Title = "Edgar Allan Poe", Genre = genres.Single(g => g.Name == "Poetry"), Price = 16.95M, Author = authors.Single(a => a.Name == "Edgar Allan Poe"), BookCoverUrl = "/Content/Images/BookCovers/Poetry/EdgarAllanPoe.jpg" },
                new Book { Title = "Born to Love, Cursed to Feel", Genre = genres.Single(g => g.Name == "Poetry"), Price = 10.90M, Author = authors.Single(a => a.Name == "Samanth King"), BookCoverUrl = "/Content/Images/BookCovers/Poetry/BornToLoveCursedToFeel.jpg" },
                new Book { Title = "The princess saves herself in this one", Genre = genres.Single(g => g.Name == "Poetry"), Price = 7.99M, Author = authors.Single(a => a.Name == "Amanda  Lovelace"), BookCoverUrl = "/Content/Images/BookCovers/Poetry/ThePrincessSavesHerselfInThisOne.jpg" },
                new Book { Title = "Eighteen Years", Genre = genres.Single(g => g.Name == "Poetry"), Price = 15.64M, Author = authors.Single(a => a.Name == "Madisen Kuhn"), BookCoverUrl = "/Content/Images/BookCovers/Poetry/EighteenYears.jpg" },
                new Book { Title = "The Universe of Us", Genre = genres.Single(g => g.Name == "Poetry"), Price = 7.38M, Author = authors.Single(a => a.Name == "Land Leav"), BookCoverUrl = "/Content/Images/BookCovers/Poetry/TheUniverseOfUs.jpg" },
                new Book { Title = "Broken Flowers", Genre = genres.Single(g => g.Name == "Poetry"), Price = 15.99M, Author = authors.Single(a => a.Name == "Robert M. Drake"), BookCoverUrl = "/Content/Images/BookCovers/Poetry/BrokenFlowes.jpg" },
                new Book { Title = "The Iliad and the Odyssey", Genre = genres.Single(g => g.Name == "Poetry"), Price = 7.18M, Author = authors.Single(a => a.Name == "Homer"), BookCoverUrl = "/Content/Images/BookCovers/Poetry/TheIlianAndTheOdyssey.jpg" },
                new Book { Title = "The Rain in Portugal", Genre = genres.Single(g => g.Name == "Poetry"), Price = 21.18M, Author = authors.Single(a => a.Name == "Billy Collins"), BookCoverUrl = "/Content/Images/BookCovers/Poetry/TheRainInPortugal.jpg" },
                new Book { Title = "Beautiful Chaos", Genre = genres.Single(g => g.Name == "Poetry"), Price = 12.25M, Author = authors.Single(a => a.Name == "Robert M. Drake"), BookCoverUrl = "/Content/Images/BookCovers/Poetry/BeautifulChaos.jpg" },
                new Book { Title = "I Wrote This For You and Only You", Genre = genres.Single(g => g.Name == "Poetry"), Price = 11.30M, Author = authors.Single(a => a.Name == "pleasefindthis"), BookCoverUrl = "/Content/Images/BookCovers/Poetry/IWroteThisForYouAndOnlyYou.jpg" },
                new Book { Title = "Dirty Pretty Things", Genre = genres.Single(g => g.Name == "Poetry"), Price = 7.62M, Author = authors.Single(a => a.Name == "Michael Faudet"), BookCoverUrl = "/Content/Images/BookCovers/Poetry/DirtyPrettyThings.jpg" },
                new Book { Title = "The Divine Comedy", Genre = genres.Single(g => g.Name == "Poetry"), Price = 7.18M, Author = authors.Single(a => a.Name == "Dante"), BookCoverUrl = "/Content/Images/BookCovers/Poetry/TheDivineComedy.jpg" },
                new Book { Title = "Bitter Sweet Love", Genre = genres.Single(g => g.Name == "Poetry"), Price = 14.67M, Author = authors.Single(a => a.Name == "Michael Faudet"), BookCoverUrl = "/Content/Images/BookCovers/Poetry/BitterSweetLove.jpg" },
                new Book { Title = "When All the Girls Have Gone", Genre = genres.Single(g => g.Name == "Romance"), Price = 21.98M, Author = authors.Single(a => a.Name == "Jayne Ann Krentz"), BookCoverUrl = "/Content/Images/BookCovers/Romance/WhenAllTheGirlsHaveGome.jpg" },
                new Book { Title = "Closer to You", Genre = genres.Single(g => g.Name == "Romance"), Price = 5.99M, Author = authors.Single(a => a.Name == "Barbara Freethy"), BookCoverUrl = "/Content/Images/BookCovers/Romance/CloserToYou.jpg" },
                new Book { Title = "Wonderland Creek", Genre = genres.Single(g => g.Name == "Romance"), Price = 13.24M, Author = authors.Single(a => a.Name == "Lynn Austin"), BookCoverUrl = "/Content/Images/BookCovers/Romance/WonderlandCreek.jpg" },
                new Book { Title = "Island of Glass", Genre = genres.Single(g => g.Name == "Romance"), Price = 9.23M, Author = authors.Single(a => a.Name == "Nora Roberts"), BookCoverUrl = "/Content/Images/BookCovers/Romance/IslandOfGlass.jpg" },
                new Book { Title = "Miracle on 5th Avenue", Genre = genres.Single(g => g.Name == "Romance"), Price = 5.05M, Author = authors.Single(a => a.Name == "Sarah Morgan"), BookCoverUrl = "/Content/Images/BookCovers/Romance/MiracleOn5thAvenue.jpg" },
                new Book { Title = "The Scottish Duke", Genre = genres.Single(g => g.Name == "Romance"), Price = 7.99M, Author = authors.Single(a => a.Name == "Karen Ranney"), BookCoverUrl = "/Content/Images/BookCovers/Romance/TheScottishDuke.jpg" },
                new Book { Title = "Chasing Shadows", Genre = genres.Single(g => g.Name == "Romance"), Price = 7.99M, Author = authors.Single(a => a.Name == "Karen Harper"), BookCoverUrl = "/Content/Images/BookCovers/Romance/ChasingShadows.jpg" },
                new Book { Title = "Saving Jake", Genre = genres.Single(g => g.Name == "Romance"), Price = 7.99M, Author = authors.Single(a => a.Name == "Sharon Sala"), BookCoverUrl = "/Content/Images/BookCovers/Romance/SavingJake.jpg" },
                new Book { Title = "Luck is No Lady", Genre = genres.Single(g => g.Name == "Romance"), Price = 7.99M, Author = authors.Single(a => a.Name == "Amy Sandas"), BookCoverUrl = "/Content/Images/BookCovers/Romance/LuckIsNoLady.jpg" },
                new Book { Title = "In Safe Hands", Genre = genres.Single(g => g.Name == "Romance"), Price = 7.99M, Author = authors.Single(a => a.Name == "Katie Ruggle"), BookCoverUrl = "/Content/Images/BookCovers/Romance/InSafeHands.jpg" },
                new Book { Title = "Christmas Roses", Genre = genres.Single(g => g.Name == "Romance"), Price = 5.99M, Author = authors.Single(a => a.Name == "Amanda Cabot"), BookCoverUrl = "/Content/Images/BookCovers/Romance/ChristmasRoses.jpg" },
                new Book { Title = "Someone to Love", Genre = genres.Single(g => g.Name == "Romance"), Price = 7.99M, Author = authors.Single(a => a.Name == "Mary Balogh"), BookCoverUrl = "/Content/Images/BookCovers/Romance/SomeoneToLove.jpg" },
                new Book { Title = "Kept", Genre = genres.Single(g => g.Name == "Romance"), Price = 12.03M, Author = authors.Single(a => a.Name == "Maya Banks"), BookCoverUrl = "/Content/Images/BookCovers/Romance/Kept.jpg" },
                new Book { Title = "Sting", Genre = genres.Single(g => g.Name == "Romance"), Price = 21.99M, Author = authors.Single(a => a.Name == "Sandra Brown"), BookCoverUrl = "/Content/Images/BookCovers/Romance/Sting.jpg" },
                new Book { Title = "Daughters of the Bride", Genre = genres.Single(g => g.Name == "Romance"), Price = 16.66M, Author = authors.Single(a => a.Name == "Susan Mallery"), BookCoverUrl = "/Content/Images/BookCovers/Romance/DaughtersOfTheBride.jpg" },
            }.ForEach(a => context.Books.Add(a));
        }
    }
}