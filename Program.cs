Page side1 = new Page(MyNotes.VariablesPageOne);
Page side2 = new Page(MyNotes.VariablesPageTwo);

Chapter kap1 = new Chapter("vars");

kap1.Pages.Add(side1);
kap1.Pages.Add(side2);

kap1.Read();

Chapter kap2 = new Chapter("BDT");

Page side1 = new Page (MyNotes.BasicDataTypesPageOne);

kap2.Pages.Add(side1);
kap2.Pages.Add(side2);

kap2.Read();