#pragma once

#define WIN32_LEAN_AND_MEAN             // 从 Windows 头文件中排除极少使用的内容
// Windows 头文件
#include <windows.h>
#include <iostream>
#include <string>
#include <opencv2/opencv.hpp>

using namespace std;
using namespace cv;


#ifdef __cplusplus //而这一部分就是告诉编译器，如果定义了__cplusplus(即如果是cpp文件，
extern "C" { //因为cpp文件默认定义了该宏),则采用C语言方式进行编译
#endif


#ifdef DLL_EXPORTS 
#define DLL_EXPORTS __declspec(dllexport)  
#else 
#define DLL_EXPORTS __declspec(dllimport)  
#endif 

	DLL_EXPORTS  uchar* GetImgBuffer(const char* p_name, int & i_size, int & i_width, int & i_height, uchar* p_buffer);

	DLL_EXPORTS  uchar* FreeImgBuffer(uchar* p_buffer);

#ifdef __cplusplus
}
#endif

