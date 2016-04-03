#include <iostream>
#include <cmath>
#include <stdio.h>
#include <string>

using namespace std;

class Candidate {
private:
	int ngay, thang, nam;
	float diem_T, diem_V, diem_A;
	string ma, ten;
public:
	Candidate() {};
	friend class TestCandidate;
	void nhap();
	void xuat();
};

class TestCandidate {
private:
	int n;
	Candidate a[1000];
public:
	TestCandidate() {};
	void nhap();
	void xuat();
};
void Candidate::nhap()
{
	cout << "nhap ma thi sinh: ";
	fflush(stdin);
	getline(cin, ma);
	cout << "nhap ten thi sinh: ";
	fflush(stdin);
	getline(cin, ten);
	cout << "nhap ngay-thang-nam sinh: " << endl;
	cin >> ngay >> thang >> nam;
	cout << "nhap diem theo thu tu toan van anh: " << endl;
	cin >> diem_T >> diem_V >> diem_A;
}
void Candidate::xuat()
{
	cout << "ma thi sinh: " << ma << endl;
	cout << "ten thi sinh: " << ten << endl;
	cout << "ngay-thang-nam sinh: " << ngay << "-" << thang << "-" << nam << endl;
	cout << "diem toan-van-anh: " << diem_T << " " << diem_V << " " << diem_A << endl;
}
void TestCandidate::nhap()
{
	cout << "nhap so sinh vien: ";
	cin >> n;
	for (int i = 0; i < n; i++)
	{
		cout << "nhap thong tin thi sinh thu: " << i + 1 << endl;
		a[i].nhap();
	}
}
void TestCandidate::xuat()
{
	cout << "---------------------------------------------------------" << endl;
	float x;
	int dem = 0;
	for (int i = 0; i < n; i++)
	{
		x = a[i].diem_T + a[i].diem_V + a[i].diem_A;
		if (x > 1)
		{
			cout << "thong tin thi sinh thu " << dem + 1 << " co tong diem lon hon 1: " << endl;
			a[i].xuat();
			dem++;
		}
	}
	if (dem == 0) cout << "khong co thi sinh nao co tong diem lon hon 1";
}

int main() {
	TestCandidate Thi_sinh;
	Thi_sinh.nhap();
	Thi_sinh.xuat();
	return 0;
}
