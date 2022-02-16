using	  System;	  
namespace	  typical_trivial{	  
	  	  	  	  class	  House{	  
private	  int	  location;	  
	  	  	  	  	  	  	  	  protected	  string	  name;	  
	  	  	  	  	  	  	  	  public	  House(){	  
	  	  	  	  	  	  	  	  	  	  	  	  name	  =	  "No	  Name	  Yet!";	  
	  	  	  	  	  	  	  	  }	  
	  	  	  	  	  	  	  	  //	  every	  class	  inherits	  ‘object’	  that	  has	  ToString()	  
public	  override	  string	  ToString(){	  
	  	  	  	  	  	  	  	  	  	  	  	  string	  disp	  =	  "Name	  is	  "	  +	  name	  +	  ",	  location=	  "	  +	  
location.ToString();	  
return	  disp;	  
	  	  	  	  	  	  	  	  }	  
	  	  	  	  }