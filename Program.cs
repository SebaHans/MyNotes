

Book mybook = new Book("My Notes");

List<Chapter> chapters = new List<Chapter> ();
Chapter chapter1 = new Chapter ("vars");
Chapter chapter2 = new Chapter ("BDT");
chapters.Add (chapter1);
chapters.Add (chapter2);

Page side1 = new Page(MyNotes.VariablesPageOne);
Page side2 = new Page(MyNotes.VariablesPageTwo);



chapter1.Pages.Add(side1);
chapter1.Pages.Add(side2);


Chapter kap2 = new Chapter("BDT");

Page side3 = new Page (MyNotes.BasicDataTypesPageOne);
Page side4 = new Page (MyNotes.BasicDataTypesPageTwo);

chapter2.Pages.Add(side3);
chapter2.Pages.Add(side4);


mybook.Chapters = chapters;
mybook.Start();
