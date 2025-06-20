package com.example.fap;

public class Test_ApplicationObject {
    private String application_status;
    private String application_type;
    private String application_create_date;
    private String application_res;
    private String application_req;

    public Test_ApplicationObject(String application_status, String application_type, String application_create_date, String application_res, String application_req) {
        this.application_status = application_status;
        this.application_type = application_type;
        this.application_create_date = application_create_date;
        this.application_res = application_res;
        this.application_req = application_req;
    }

    public String getApplication_status() {
        return application_status;
    }

    public void setApplication_status(String application_status) {
        this.application_status = application_status;
    }

    public String getApplication_type() {
        return "Type: " + application_type;
    }

    public void setApplication_type(String application_type) {
        this.application_type = application_type;
    }

    public String getApplication_create_date() {
        return "Create date: " + application_create_date;
    }

    public void setApplication_create_date(String application_create_date) {
        this.application_create_date = application_create_date;
    }

    public String getApplication_res() {
        return application_res;
    }

    public void setApplication_res(String application_res) {
        this.application_res = application_res;
    }

    public String getApplication_req() {
        return application_req;
    }

    public void setApplication_req(String application_req) {
        this.application_req = application_req;
    }

}
