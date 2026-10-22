#ifndef _Land_h_included_
#define _Land_h_included_

#include "Environment.h"

class Land : public Environment
{ 
public:
  Land();
  void InitLand();
  void DrawEnvironment();
};
#endif

