#include <stdio.h>

#include <stdlib.h>

int main() {

	int s = 0, step[4][2] = { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, -1 } };

	int **p = NULL;

	int n, i;

	int x = -1, y = 0, tmpX, tmpY;

	printf("输入阶数：");

	scanf_sa("%d", &n);

	//动态分配内存并初始化为0

	p = (int **)malloc(sizeof(int *)* n);

	for (i = 0; i < n; i++)

		*(p + i) = (int *)calloc(n, sizeof(int));

	//生成螺旋数组

	for (i = 1; i <= n * n; i++) {

		tmpX = x + step[s][0]; //下一个位置的坐标

		tmpY = y + step[s][1]; //下一个位置的坐标

		while (tmpX == n || tmpX < 0 || tmpY == n || tmpY < 0 || p[tmpY][tmpX] > 0) { //如果坐标超出范围或者下一个位置已经填写了数字

			s = ++s % 4; //拐弯

			tmpX = x + step[s][0];

			tmpY = y + step[s][1];

		}

		x = x + step[s][0];

		y = y + step[s][1];

		p[y][x] = i;  //填写数字

	}

	//输出

	for (x = 0; x < n; x++) {

		for (y = 0; y < n; y++)

			printf("%5d", p[x][y]);

		printf("\n");

	}

	//释放动态分配的内存空间

	for (i = 0; i < n; i++) {

		free(*(p + i));

		p[i] = NULL;

	}



	free(p);

	p = NULL;

	return 0;

}