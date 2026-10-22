#ifndef _GUI_h_included_
#define _GUI_h_included_

#include "Environment.h"

class GUI : public Environment
{ 
public:
  GUI();
  void InitGUI();
  void DrawEnvironment();
};
#endif

