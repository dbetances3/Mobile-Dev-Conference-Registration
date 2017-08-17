Requirements Document
Date Submitted:   August 16, 2017
Application       Title: Mobile Developer's Conference Registration 

Purpose:          This Windows application allows a visitor to the Mobile Developer's conference to 
                  register for the meeting.
                
Program           In a Windows application, the user enters the visitor's corporation ID, first and last name,
Procedures:       and the number of days the visitor will be attending. The user selects whether a pre-conference
                  course is being attended and selects the course if necessary. The user then clicks a button.
                  The application calculates the costs for attending the conference and records the information in a log file.
                
                
Algorithms,       1. The user first enters the visitor's corporation ID, first and last name, and number of 
Processing, and      days to attend.
Conditions:       2. The user selects whether the visitor will attend a pre-conference course (Pre-Conference
                     Android Track or Windows Store Track) and then selects the course if necessary (for 
                     example, Mobile Security, Mobile Design, or Mobile Databases).
                  3. When the user clicks the calculate costs button, the program calculates the costs for attending the
                     conference and writes a log file.
                  4. A Clear Form button is available to clear the form and place the insertion 
                     point in the Corporation ID text box.
                  5. The conference cost is $350.00 per day. The minimum number of days is 1, and
                     the maximum number of days is 4.
                  6. The formula to calculate conference costs is number of days times the cost per day.
                  7. If the visitor chooses to attend one of the pre-conference courses, it will cost 
                     $675.00. This cost should be added to the conference cost.
                  8. The log file is a text file that contains the corporation ID, the First Name, the 
                     Last Name, the pre-conference course is taken, the field contains no data for it in the text file
                     record. The file is comma-delimited file. 
                     
                     
Notes and
Restrictions:     1. The Corporation ID must be a five numeric digits in length.
                  2. The first name and the last name cannot be left blank and must begin with an
                     alphabetic character.
                  3. The number of days must be a numeric value of 1 through 4.
                  4. The pre-conference course selections should not be displayed in the window unless
                     the user selects a type of pre-conference course.
                  5. When the user clicks the button to calculate costs and the program determines that
                     an error occurred during the data entry, a message box should be displayed and the user 
                     must enter valid data before continuing.
                  6. No pre-conference course is the default value.
                  
                  
