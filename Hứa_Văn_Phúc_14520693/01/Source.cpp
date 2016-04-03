#include <iostream>
#include <cmath>

using namespace std;

int USCLN(int x, int y)
{
	if (x * y == 0) return 1;
	while (x != y)
	{
		if (x > y) x -= y;
		else y -= x;
	}
	return x;
}

class PS {
private:
	int tu, mau;
public:
	PS(int tu = 0, int mau = 0)
	{
		this->tu = tu;
		this->mau = mau;
	}
	friend istream& operator>>(istream& is, PS &p)
	{
		cout << "nhap tu so: ";
		is >> p.tu;
		do {
			cout << "nhap mau so: ";
			is >> p.mau;
		} while (p.mau == 0);
		return is;
	}
	friend ostream& operator<<(ostream& os, PS p)
	{
		os << p.tu << "/" << p.mau;
		return os;
	}
	PS rut_gon()
	{
		PS q;
		int x = USCLN(abs(this->tu), abs(this->mau));
		q.tu = this->tu / x;
		q.mau = this->mau / x;
		return q;
	}
	PS operator+(PS p)
	{
		PS q;
		q.tu = this->tu*p.mau + this->mau*p.tu;
		q.mau = this->mau*p.mau;
		return q.rut_gon();
	}
	PS operator-(PS p)
	{
		PS q;
		q.tu = this->tu*p.mau - this->mau*p.tu;
		q.mau = this->mau*p.mau;
		return q.rut_gon();
	}
	PS operator*(PS p)
	{
		PS q;
		q.tu = this->tu * p.tu;
		q.mau = this->mau * p.mau;
		return q.rut_gon();
	}
	PS operator/(PS p)
	{
		PS q;
		q.tu = this->tu * p.mau;
		q.mau = this->mau * p.tu;
		if (q.mau == 0)
		{
			cout << "khong chia duoc ";
			return PS(0, 1);
		}
		return q.rut_gon();
	}
};
int main()
{
	PS a, b;
	cin >> a >> b;
	cout << "tong: " << a + b << endl;
	cout << "hieu: " << a - b << endl;
	cout << "tich: " << a*b << endl;
	cout << "thuong: " << a / b << endl;
	return 0;
}
