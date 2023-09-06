

Book mybook = new Book("My Notes");

List<Chapter> chapters = new List<Chapter> ();
Chapter chapter1 = new Chapter ("vars");
Chapter chapter2 = new Chapter ("bdt");
Chapter chapter3 = new Chapter ("conds");
chapters.Add (chapter1);
chapters.Add (chapter2);
chapters.Add (chapter3);

Page Vside1 = new Page(MyNotes.VariablesPageOne);
Page Vside2 = new Page(MyNotes.VariablesPageTwo);
Page Vside3 = new Page(MyNotes.VariablesPageThree);



chapter1.Pages.Add(Vside1);
chapter1.Pages.Add(Vside2);
chapter1.Pages.Add(Vside3);


Page Bside1 = new Page (MyNotes.BasicDataTypesPageOne);
Page Bside2 = new Page (MyNotes.BasicDataTypesPageTwo);
Page Bside3 = new Page (MyNotes.BasicDataTypesPageThree);
Page Bside4 = new Page (MyNotes.BasicDataTypesPageFour);

chapter2.Pages.Add(Bside1);
chapter2.Pages.Add(Bside2);
chapter2.Pages.Add(Bside3);
chapter2.Pages.Add(Bside4);

Page Cside1 = new Page (MyNotes.ConditionalsPageOne);
Page Cside2 = new Page (MyNotes.ConditionalsPageTwo);
Page Cside3 = new Page (MyNotes.ConditionalsPageThree);
Page Cside4 = new Page (MyNotes.ConditionalsPageFour);
Page Cside5 = new Page (MyNotes.ConditionalsPageFive);

chapter3.Pages.Add(Cside1);
chapter3.Pages.Add(Cside2);
chapter3.Pages.Add(Cside3);
chapter3.Pages.Add(Cside4);
chapter3.Pages.Add(Cside5);

mybook.Chapters = chapters;
mybook.Start();
