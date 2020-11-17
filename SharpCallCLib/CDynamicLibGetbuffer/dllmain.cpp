// dllmain.cpp : 定义 DLL 应用程序的入口点。
#include "pch.h"

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

uchar* GetImgBuffer(const string p_imgName, int & i_size, int & i_width, int & i_height, uchar* p_buffer)
{
	Mat src = imread(p_imgName);

	i_width = src.cols;
	i_height = src.rows;

	i_size = i_width * i_height *src.channels();
	p_buffer = (uchar*)malloc(i_size*sizeof(uchar));



	memcpy(p_buffer, src.data, i_size);

	return p_buffer;
}

uchar* FreeImgBuffer(uchar* p_buffer)
{
	free(p_buffer);
	p_buffer = NULL;
	return p_buffer;
}