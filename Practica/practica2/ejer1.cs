//1Qué líneas del siguiente código provocan conversiones boxing y unboxing.
char c1 = 'A';
string st1 = "A";
object o1 = c1;//boxing
object o2 = st1;//boxing
char c2 = (char)o1; //unboxing
string st2 = (string)o2; //unboxing
