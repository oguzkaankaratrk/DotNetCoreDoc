//ders 16 devamı common type system (cts)

///Temel türlerde başka türden türetilmiş olabilir. 
///Örneğin -> dog : animal / animal : canlı / canlı : atom  (: kalıtım işaretidir.)
///System.Object : Tüm türler  örneğin int System.Int32 de dahil olmak üzere nihai olarak tek bir temel türden türetilir. Bu türde System.Object dir.
///Bu birleştirilmiş tür hiyerarşisine Common Type System denir.
///
///cts deki her tür, değer tür veya referans tür olarak tanımlanır. 
/// struct anahtar kelimesini kullanarak tanımlanan türler değer türlerdir.
/// tüm sayısal türler struct tır. 
/// record veya class referans türdür. 
/// 


//tür hiyerarşisi
int number = 42; 
string text = "mushab";

Console.WriteLine(number.GetType()); //system.int32 nin takma adıdıe.
Console.WriteLine(text.GetType()); //system.string
Console.WriteLine(number.ToString()); //42 //system.object
