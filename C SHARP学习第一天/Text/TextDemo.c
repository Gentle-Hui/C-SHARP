#include <stdio.h>

#include <stdlib.h>

int main() {

	int s = 0, step[4][2] = { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, -1 } };

	int **p = NULL;

	int n, i;

	int x = -1, y = 0, tmpX, tmpY;

	printf("���������");

	scanf_sa("%d", &n);

	//��̬�����ڴ沢��ʼ��Ϊ0

	p = (int **)malloc(sizeof(int *)* n);

	for (i = 0; i < n; i++)

		*(p + i) = (int *)calloc(n, sizeof(int));

	//������������

	for (i = 1; i <= n * n; i++) {

		tmpX = x + step[s][0]; //��һ��λ�õ�����

		tmpY = y + step[s][1]; //��һ��λ�õ�����

		while (tmpX == n || tmpX < 0 || tmpY == n || tmpY < 0 || p[tmpY][tmpX] > 0) { //������곬����Χ������һ��λ���Ѿ���д������

			s = ++s % 4; //����

			tmpX = x + step[s][0];

			tmpY = y + step[s][1];

		}

		x = x + step[s][0];

		y = y + step[s][1];

		p[y][x] = i;  //��д����

	}

	//���

	for (x = 0; x < n; x++) {

		for (y = 0; y < n; y++)

			printf("%5d", p[x][y]);

		printf("\n");

	}

	//�ͷŶ�̬������ڴ�ռ�

	for (i = 0; i < n; i++) {

		free(*(p + i));

		p[i] = NULL;

	}



	free(p);

	p = NULL;

	return 0;

}