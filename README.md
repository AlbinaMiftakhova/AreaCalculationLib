# AreaCalculationLib

Библиотека AreaCalculationLib предназначена для вычисления площади круга и треугольника 
на основе радиуса и трех сторон соответственно (без знания типа фигуры). При вычислении площади 
треугольника также определяется, является ли он прямоугольным.

Для добавления функционала вычисления площади 
другой фигуры нужно создать для нее класс-наследник Figure с необходимыми параметрами,
реализовать нужную логику в методе Area и добавить соответсвующую реализацию метода CreateFigure в FigureCreator.

Для основного функционала написаны юнит-тесты с использованием xUnit.
