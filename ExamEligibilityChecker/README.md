# Exam Eligibility Checker
A console application that calculates a student's weighted average from four assessment marks (Test1, Test2, Assignment1, Project) and determines whether they qualify to write the exam (weighted average >=50)

## Prerequisites
-Docker Desktop installed and running

## How to run
1.Pull the image from Docker Hub:
docker pull donovanfraser/exam-eligibility-checker:latest

2.Run the container:
docker run -it donovanfraser/exam-eligibility-checker:latest

3.Enter your marks when prompted (each out of 100):
-Test 1 (weight 30%)
-Test 2 (weight 50%)
-Assignment 1 (weighty 10%)
-Project (weight 10%)

## Example

=== EXAM Eligibility Checker ===
Enter Test 1 mark (weight 30%): 10
Enter Test 2 mark (weight 50%): 90
Enter Assignment 1 mark (weight 10%): 98
Enter Project mark (weight 10%): 99

Weighted average:67.70
Result: You QUALIFY to write the exam.
