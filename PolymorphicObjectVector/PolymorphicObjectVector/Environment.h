#ifndef _ENVIRONMENT_h_included_
#define _ENVIRONMENT_h_included_


class Environment
{ 
public:
  Environment();
  void InitEnvironment();
  virtual void DrawEnvironment() = 0;
};
#endif

