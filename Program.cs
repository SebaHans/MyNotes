

Book mybook = new Book("My Notes");

List<Chapter> chapters = new List<Chapter> ();
Chapter chapter1 = new Chapter ("vars");
Chapter chapter2 = new Chapter ("bdt");
Chapter chapter3 = new Chapter ("conds");
Chapter chapter4 = new Chapter ("arra");
Chapter chapter5 = new Chapter ("loops");
Chapter chapter6 = new Chapter ("Meth");
Chapter chapter7 = new Chapter ("OOP");
chapters.Add (chapter1);
chapters.Add (chapter2);
chapters.Add (chapter3);
chapters.Add (chapter4);
chapters.Add (chapter5);
chapters.Add (chapter6);
chapters.Add (chapter7);

List<Page> pages= new List<Page> ();

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


Page Aside1 = new Page (MyNotes.ArraysPageOne);
Page Aside2 = new Page (MyNotes.ArraysPageTwo);
Page Aside3 = new Page (MyNotes.ArraysPageThree);

chapter4.Pages.Add(Aside1);
chapter4.Pages.Add(Aside2);
chapter4.Pages.Add(Aside3);


Page Lside1 = new Page (MyNotes.LoopsPageOne);
Page Lside2 = new Page (MyNotes.LoopsPageTwo);
Page Lside3 = new Page (MyNotes.LoopsPageThree);
Page Lside4 = new Page (MyNotes.LoopsPageFour);
Page Lside5 = new Page (MyNotes.LoopsPageFive);
Page Lside6 = new Page (MyNotes.LoopsPageSix);
Page Lside7 = new Page (MyNotes.LoopsPageSeven);

chapter5.Pages.Add(Lside1);
chapter5.Pages.Add(Lside2);
chapter5.Pages.Add(Lside3);
chapter5.Pages.Add(Lside4);
chapter5.Pages.Add(Lside5);
chapter5.Pages.Add(Lside6);
chapter5.Pages.Add(Lside7);


Page Mside1 = new Page (MyNotes.MethodsPageOne);
Page Mside2 = new Page (MyNotes.MethodsPageTwo);

chapter6.Pages.Add(Mside1);
chapter6.Pages.Add(Mside2);

Page Oside1 = new Page (MyNotes.OOPPageOne);
Page Oside2 = new Page (MyNotes.OOPPageTwo);
Page Oside3 = new Page (MyNotes.OOPPageThree);
Page Oside4 = new Page (MyNotes.OOPPageFour);
Page Oside5 = new Page (MyNotes.OOPPageFive);

chapter7.Pages.Add(Oside1);
chapter7.Pages.Add(Oside2);
chapter7.Pages.Add(Oside3);
chapter7.Pages.Add(Oside4);
chapter7.Pages.Add(Oside5);

mybook.Chapters = chapters;
mybook.Start();
