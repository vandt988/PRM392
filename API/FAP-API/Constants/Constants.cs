namespace FAP_API.Constants
{
    public static class ConstantsValue
    {
        //Quyền tài khoản
        public const int ROLE_ADMIN = 2;
        public const int ROLE_TEACHER = 3;
        public const int ROLE_STUDENT = 4;
        public const int ROLE_TESTING = 5;

        // Loại bài kiểm tra (EXAM_TYPE)
        public const int EXAM_TYPE_FE = 7;
        public const int EXAM_TYPE_2NDFE = 8;
        public const int EXAM_TYPE_PE = 9;

        // Ghi chú lịch kiểm tra (EXAM_NOTE)
        public const int EXAM_NOTE_MULTI_CHOICES_EOS = 11;
        public const int EXAM_NOTE_PRACTICAL_EXAM_EOS = 12;
        public const int EXAM_NOTE_PRACTICAL_EXAM_PEA = 13;
        public const int EXAM_NOTE_READING_WRITING_EOS = 14;
        public const int EXAM_NOTE_PROJECT_PRESENT = 15;
        public const int EXAM_NOTE_RVW_ON_EOS = 16;
        public const int EXAM_NOTE_THUC_HANH = 17;

        // Trạng thái điểm danh (ROLL_CALL_STATUS)
        public const int ROLL_CALL_PRESENT = 19;
        public const int ROLL_CALL_ABSENT = 20;
        public const int ROLL_CALL_NOT_YET = 21;

        // Học kì (SEMESTER)
        public const int SEMESTER_SPRING = 23;
        public const int SEMESTER_SUMMER = 24;
        public const int SEMESTER_FALL = 25;
    }

    public static class ConstantsDescription
    {
        // Quyền tài khoản
        public const string ROLE_ADMIN = "ROLE_ADMIN";
        public const string ROLE_TEACHER = "ROLE_TEACHER";
        public const string ROLE_STUDENT = "ROLE_STUDENT";
        public const string ROLE_TESTING = "ROLE_TESTING";

        // Loại bài kiểm tra (EXAM_TYPE)
        public const string EXAM_TYPE_FE = "Thi FE";
        public const string EXAM_TYPE_2NDFE = "Thi lại FE";
        public const string EXAM_TYPE_PE = "Thi PE";

        // Ghi chú lịch kiểm tra (EXAM_NOTE)
        public const string EXAM_NOTE_MULTI_CHOICES_EOS = "Multiple_choices on EOS";
        public const string EXAM_NOTE_PRACTICAL_EXAM_EOS = "Practical_Exam (EOS client)";
        public const string EXAM_NOTE_PRACTICAL_EXAM_PEA = "Practical_Exam (PEA client)";
        public const string EXAM_NOTE_READING_WRITING_EOS = "Reading, Writing on EOS";
        public const string EXAM_NOTE_PROJECT_PRESENT = "Project Presentation";
        public const string EXAM_NOTE_RVW_ON_EOS = "Reading, Vocabulary, Writing on EOS";
        public const string EXAM_NOTE_THUC_HANH = "Thực hành";

        // Trạng thái điểm danh (ROLL_CALL_STATUS)
        public const string ROLL_CALL_PRESENT = "present";
        public const string ROLL_CALL_ABSENT = "absent";
        public const string ROLL_CALL_NOT_YET = "not yet";

        // Học kì (SEMESTER)
        public const string SEMESTER_SPRING = "Spring"; 
        public const string SEMESTER_SUMMER = "Summer";
        public const string SEMESTER_FALL = "Fall";
    }

    public static class UserRoleEnum
    {
        public enum UserRoleE
        {
            ROLE_ADMIN = 2,
            ROLE_TEACHER = 3,
            ROLE_STUDENT = 4,
            ROLE_TESTING = 5,
        }
    }
}
