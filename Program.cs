

Book mybook = new Book("My Notes");

List<Chapter> chapters = new List<Chapter> ();
Chapter chapter1 = new Chapter ("vars");
Chapter chapter2 = new Chapter ("BDT");
Chapter chapter3 = new Chapter ("");
chapters.Add (chapter1);
chapters.Add (chapter2);

Page Vside1 = new Page(MyNotes.VariablesPageOne);
Page Vside2 = new Page(MyNotes.VariablesPageTwo);
Page Vside3 = new Page(MyNotes.VariablesPageThree);



chapter1.Pages.Add(Vside1);
chapter1.Pages.Add(Vside2);
chapter1.Pages.Add(Vside3);


Chapter kap2 = new Chapter("BDT");

Page Bside1 = new Page (MyNotes.BasicDataTypesPageOne);
Page Bside2 = new Page (MyNotes.BasicDataTypesPageTwo);

chapter2.Pages.Add(Bside1);
chapter2.Pages.Add(Bside2);


mybook.Chapters = chapters;
mybook.Start();
