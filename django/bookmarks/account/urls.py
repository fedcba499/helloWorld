from django.conf.urls import url
from . import views

urlpatterns = [
    urls(r'^login/$', views.user_login, name = 'login'),
    
]