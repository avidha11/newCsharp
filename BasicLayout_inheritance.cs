using System;
                
abstract class  Vehicle
{

}
class Engine{}
class Transmission{}
class Car : Vehicle
{
	Engine eobj = new Engine();
	Transmission tobj = new Transmission();
	
}

using System;
using System.Collections.Generic;
                
abstract class Document{}
class Header{}
class Margin{}
class Paragraph{}

class Page
{
	Header hobj = new Header();
	Margin mobj = new Margin();
	List<Paragraph> paraobj = new List<Paragraph>();
}

class Ms_Word : Document
{
	List<Page> pobj = new List<Page>();
}
