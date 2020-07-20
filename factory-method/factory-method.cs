using System;
using System.Collections.Generic;

/* PAGES */
public abstract class Page { }

public class SkillsPage : Page { }
public class EducationPage : Page { }
public class ExperiencePage : Page { }
public class IntroductionPage : Page { }
public class ResultsPage : Page { }
public class ConclusionPage : Page { }
public class SummaryPage : Page { }
public class BibliographyPage : Page { }

/* DOCUMENTS */
public abstract class Document
{
    private List<Page> _pages = new List<Page>();
    public Document() { this.CreatePages(); }
    public List<Page> Pages => _pages;
    public abstract void CreatePages();
}

public class Resume : Document
{
    public override void CreatePages()
    {
        Pages.Add(new SkillsPage());
        Pages.Add(new EducationPage());
        Pages.Add(new ExperiencePage());
    }
}

class Report : Document
{
    public override void CreatePages()
    {
        Pages.Add(new IntroductionPage());
        Pages.Add(new ResultsPage());
        Pages.Add(new ConclusionPage());
        Pages.Add(new SummaryPage());
        Pages.Add(new BibliographyPage());
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Document[] documents = new Document[2];
        documents[0] = new Resume();
        documents[1] = new Report();
        foreach (Document document in documents)
        {
            Console.WriteLine("\n" + document.GetType() + "--");
            foreach (Page page in document.Pages)
            {
                Console.WriteLine(" " + page.GetType().Name);
            }
        }
    }
}