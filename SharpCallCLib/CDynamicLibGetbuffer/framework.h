#pragma once

#define WIN32_LEAN_AND_MEAN             // 从 Windows 头文件中排除极少使用的内容
// Windows 头文件
#include <windows.h>
#include <iostream>
#include <string>
#include <opencv2/opencv.hpp>

using namespace std;
using namespace cv;

extern "C"
{
	__declspec(dllexport) uchar* GetImgBuffer(const string p_name, int & i_size, int & i_width, int & i_height, uchar* p_buffer);

	__declspec(dllexport) uchar* FreeImgBuffer(uchar* p_buffer);

}

