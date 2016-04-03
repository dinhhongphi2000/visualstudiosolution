#include <iostream>
#include <cmath>

using namespace std;

class Sophuc {
private:
	double thuc, ao;
public:
	Sophuc(double x = 0, double y = 1)
	{
		this->thuc = x;
		this->ao = y;
	}
	friend istream& operator>>(istream& is, Sophuc &p)
	{
		do {
			cout << "nhap phan thuc: ";
			is >> p.thuc;
			cout << "nhap phan ao: ";
			is >> p.ao;
		} while (p.thuc == 0 && p.ao == 0);
		return is;
	}
	friend ostream& operator<<(ostream& os, Sophuc p)
	{
		os << p.thuc << " + " << p.ao << "i";
		return os;
	}
	Sophuc operator+(Sophuc p)
	{
		Sophuc q;
		q.thuc = thuc + p.thuc;
		q.ao = ao + p.ao;
		return q;
	}
	Sophuc operator-(Sophuc p)
	{
		Sophuc q;
		q.thuc = thuc - p.thuc;
		q.ao = ao - p.ao;
		return q;
	}
	Sophuc operator*(Sophuc p)
	{
		Sophuc q;
		q.thuc = thuc*p.thuc - ao*p.ao;
		q.ao = this->thuc*p.ao + p.thuc*ao;
		return q;
	}
	Sophuc operator/(Sophuc p)
	{
		Sophuc q;
		q.thuc = (thuc*p.thuc + ao*p.ao) / (p.thuc*p.thuc + p.ao*p.ao);
		q.ao = (p.thuc*ao - thuc*p.ao) / (p.thuc*p.thuc + p.ao*p.ao);
		return q;
	}
};

int main() {
	Sophuc a, b;
	cin >> a >> b;
	cout << "tong hai so: " << a + b << endl;
	cout << "hieu hai so: " << a - b << endl;
	cout << "tich hai so: " << a*b << endl;
	cout << "thuong hai so: " << a / b;
	return 0;
}
