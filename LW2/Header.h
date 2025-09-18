#pragma once
#include <iostream>
#include <vector>
#include <stdexcept>
#include <cstdlib>
#include <ctime>
#include<Windows.h>
using namespace std;
////////////////////////////////////////*,(<,>,==,!=,<<,>>)
class MyArr {
private:
    vector<vector<double>> array;

public:
    int rows() const { return array.size(); }
    int cols() const { return array.empty() ? 0 : array[0].size(); }

    double& operator()(int i, int j) {
        return array[i][j];
    }

    double operator()(int i, int j) const {
        return array[i][j];
    }

    MyArr(int n, int m) {
        array.assign(n, vector<double>(m, 0));
    }

    void FillArr() {
        srand(time(0));
        for (int i = 0; i < rows(); i++)
            for (int j = 0; j < cols(); j++)
                array[i][j] = rand() % 100 + 1;
    }

    void Out() const {
        for (int i = 0; i < rows(); i++) {
            for (int j = 0; j < cols(); j++)
                cout << array[i][j] << "\t";
            cout << endl;
        }
    }

    // ++
    MyArr& operator++() {
        for (int i = 0; i < rows(); i++)
            for (int j = 0; j < cols(); j++)
                array[i][j]++;
        return *this;
    }

    // --
    MyArr& operator--() {
        for (int i = 0; i < rows(); i++)
            for (int j = 0; j < cols(); j++)
                array[i][j]--;
        return *this;
    }

    // �������� ���������� �����
    explicit operator bool() const {
        for (int i = 0; i < rows(); i++)
            for (int j = 1; j < cols(); j++)
                if (array[i][j] < array[i][j - 1])
                    return false;
        return true;
    }

    // �������� �������
    MyArr operator*(const MyArr& b) const {
        if (cols() != b.rows())
            throw runtime_error("����i�� ������� �� �i������� ��� ��������!");

        MyArr result(rows(), b.cols());

        for (int i = 0; i < rows(); i++) {
            for (int j = 0; j < b.cols(); j++) {
                for (int k = 0; k < cols(); k++) {
                    result(i, j) += array[i][k] * b(k, j);
                }
            }
        }

        return result;
    }

    // ���� � ���������� ����� 
    vector<vector<double>> ToJagged() const {
        return array;
    }

    // ��������� � ����������� ������
    static MyArr FromJagged(const vector<vector<double>>& jagged) {
        int n = jagged.size();
        int m = jagged[0].size();
        MyArr res(n, m);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                res(i, j) = jagged[i][j];
        return res;
    }
    //<<
    friend ostream& operator<<(ostream& os, const MyArr& m) {
        for (int i = 0; i < m.rows(); i++) {
            for (int j = 0; j < m.cols(); j++)
                os << m(i, j) << "\t";
            os << endl;
        }
        return os;
    }
    //>>
    friend istream& operator>>(istream& is, MyArr& m) {
        for (int i = 0; i < m.rows(); i++)
            for (int j = 0; j < m.cols(); j++)
                is >> m(i, j);
        return is;
    }

    // �������������� ==
    bool operator==(const MyArr& b) const {
        if (rows() != b.rows() || cols() != b.cols()) return false;
        for (int i = 0; i < rows(); i++)
            for (int j = 0; j < cols(); j++)
                if ((*this)(i, j) != b(i, j))
                    return false;
        return true;
    }

    // �������������� <
    bool operator<(const MyArr& b) const {
        if (rows() != b.rows() || cols() != b.cols())
            throw runtime_error("����i�� ������� �� ��i������� ��� ���i������!");
        for (int i = 0; i < rows(); i++)
            for (int j = 0; j < cols(); j++)
                if ((*this)(i, j) >= b(i, j))
                    return false;
        return true;
    }

    // �������������� >
    bool operator>(const MyArr& b) const {
        if (rows() != b.rows() || cols() != b.cols())
            throw runtime_error("����i�� ������� �� ��i������� ��� ���i������!");
        for (int i = 0; i < rows(); i++)
            for (int j = 0; j < cols(); j++)
                if ((*this)(i, j) <= b(i, j))
                    return false;
        return true;
    }
    //�������������� !=
    bool operator!=(const MyArr& b) const {
        return !(*this == b);
    }
};