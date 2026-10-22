#ifndef _Sky_h_included_
#define _Sky_h_included_

#include "Environment.h"

class Sky : public Environment
{ 
public:
  Sky();
  void InitSky();
  void DrawEnvironment();
};
#endif

