#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include <string>
#include <limits>
#include <sstream>
#include <locale>
#include <codecvt>

using namespace std;

class Student {
private:
    string fullName;
    string specialty;
    string groupNumber;
    double averageScore;

public:
    Student() : averageScore(0) {}
    Student(string name, string spec, string group, double score)
        : fullName(name), specialty(spec), groupNumber(group), averageScore(score) {}

    // Геттеры
    string getFullName() const { return fullName; }
    string getSpecialty() const { return specialty; }
    string getGroupNumber() const { return groupNumber; }
    double getAverageScore() const { return averageScore; }

    // Метод для записи в файл
    void writeToFile(ofstream& outFile) const {
        outFile << fullName << "#" << specialty << "#" << groupNumber << "#" << averageScore << "\n";
    }

    // Метод для чтения из файла
    static Student readFromFile(ifstream& inFile) {
        Student student;
        string line;
        if (getline(inFile, line)) {
            size_t pos1 = line.find('#');
            size_t pos2 = line.find('#', pos1 + 1);
            size_t pos3 = line.find('#', pos2 + 1);

            student.fullName = line.substr(0, pos1);
            student.specialty = line.substr(pos1 + 1, pos2 - pos1 - 1);
            student.groupNumber = line.substr(pos2 + 1, pos3 - pos2 - 1);
            student.averageScore = stod(line.substr(pos3 + 1));
        }
        return student;
    }

    // Метод для вывода в консоль
    void display() const {
        cout << "ФИО: " << fullName << "\nСпециальность: " << specialty
            << "\nГруппа: " << groupNumber << "\nСредний балл: " << averageScore << "\n\n";
    }
};

// Функция проверки ФИО (должно быть ровно 3 слова)
bool isValidFullName(const string& name) {
    istringstream iss(name);
    string word;
    int wordCount = 0;

    while (iss >> word) {
        wordCount++;
    }

    return wordCount == 3;
}

// Функции сравнения для сортировки
bool compareByScoreAsc(const Student& a, const Student& b) {
    return a.getAverageScore() < b.getAverageScore();
}

bool compareByScoreDesc(const Student& a, const Student& b) {
    return a.getAverageScore() > b.getAverageScore();
}

void addStudentToFile(const string& filename) {
    // Открываем файл с правильной кодировкой
    ofstream outFile(filename, ios::app);
    outFile.imbue(locale("Russian"));

    if (!outFile) {
        cerr << "Ошибка открытия файла!\n";
        return;
    }

    string name, spec, group;
    double score;

    // Ввод ФИО с проверкой
    while (true) {
        cout << "Введите ФИО студента (3 слова): ";
        getline(cin, name);

        if (isValidFullName(name)) {
            break;
        }
        cout << "Ошибка! ФИО должно содержать ровно 3 слова. Попробуйте снова.\n";
    }

    cout << "Введите специальность: ";
    getline(cin, spec);

    cout << "Введите номер группы: ";
    getline(cin, group);

    // Ввод среднего балла с проверкой
    while (true) {
        cout << "Введите средний балл: ";
        cin >> score;

        if (cin.fail() || score < 0 || score > 5) {
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            cout << "Ошибка! Введите число от 0 до 5.\n";
        }
        else {
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            break;
        }
    }

    Student student(name, spec, group, score);
    student.writeToFile(outFile);
    outFile.close();
    cout << "Студент успешно добавлен!\n";
}

void sortAndDisplayStudents(const string& filename, bool ascending) {
    // Открываем файл с правильной кодировкой
    ifstream inFile(filename);
    inFile.imbue(locale("Russian"));

    if (!inFile) {
        cerr << "Ошибка открытия файла!\n";
        return;
    }

    vector<Student> students;
    while (inFile.peek() != EOF) {
        students.push_back(Student::readFromFile(inFile));
    }
    inFile.close();

    if (ascending) {
        sort(students.begin(), students.end(), compareByScoreAsc);
        cout << "\nСортировка по возрастанию среднего балла:\n";
    }
    else {
        sort(students.begin(), students.end(), compareByScoreDesc);
        cout << "\nСортировка по убыванию среднего балла:\n";
    }

    for (const auto& student : students) {
        student.display();
    }
}

int main() {
    // Устанавливаем локаль для консоли и файлов
    setlocale(LC_ALL, "Russian");


    const string filename = "students.txt";
    int choice;

    do {
        cout << "\nМеню:\n";
        cout << "1. Добавить студента\n";
        cout << "2. Показать студентов (по возрастанию среднего балла)\n";
        cout << "3. Показать студентов (по убыванию среднего балла)\n";
        cout << "4. Выход\n";
        cout << "Выберите действие: ";

        while (!(cin >> choice) || choice < 1 || choice > 4) {
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            cout << "Неверный выбор. Введите число от 1 до 4: ";
        }
        cin.ignore(numeric_limits<streamsize>::max(), '\n');

        switch (choice) {
        case 1:
            addStudentToFile(filename);
            break;
        case 2:
            sortAndDisplayStudents(filename, true);
            break;
        case 3:
            sortAndDisplayStudents(filename, false);
            break;
        case 4:
            cout << "Выход из программы.\n";
            break;
        }
    } while (choice != 4);

    return 0;
}