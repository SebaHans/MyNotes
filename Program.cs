Page side1 = new Page(MyNotes.VariablesPageOne);
Page side2 = new Page(MyNotes.VariablesPageTwo);

Chapter kap1 = new Chapter("vars");

kap1.Pages.Add(side1);
kap1.Pages.Add(side2);

kap1.Read();

Chapter kap2 = new Chapter("BDT");

Page side3 = new Page (MyNotes.BasicDataTypesPageOne);
Page side4 = new Page (MyNotes.BasicDataTypesPageTwo);

kap2.Pages.Add(side3);
kap2.Pages.Add(side4);

kap2.Read();